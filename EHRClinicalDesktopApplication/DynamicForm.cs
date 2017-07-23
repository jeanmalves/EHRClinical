using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EHRClinicalDesktopApplication
{
    public partial class DynamicForm : Form
    {
        public MainForm FormParent { get; private set; }
        public OperationalsTemplate dataTemplate { get; private set; }
        public DynamicForm(MainForm formParent, OperationalsTemplate obj)
        {
            InitializeComponent();
            FormParent = formParent;
            dataTemplate = obj;
        }

        private void DynamicForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            loadData();
        }

        private void loadData()
        {
            Label label = new Label();
            label.Location = new Point(33, 24);
            label.Size = new Size(144, 23);
            label.Text = dataTemplate.Name;
            Controls.Add(label);
            
            int height = 110;

            var patients = PatientBLL.GetPatientsList();
            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "Value";

            foreach (var item in dataTemplate.TemplateAttributes)
            {
                Label attributeLabel = new Label();

                attributeLabel.Location = new Point(39, height);
                attributeLabel.Name = "lbl" + item.Attribute;
                attributeLabel.Text = item.Attribute;
                attributeLabel.UseCompatibleTextRendering = true;
                
                Controls.Add(attributeLabel);

                if (item.Type == "TEXT")
                {
                    TextBox textAttribute = new TextBox();

                    textAttribute.Location = new Point(149, height);
                    textAttribute.Name = "text" + item.Attribute;
                    textAttribute.Tag = item;
                    textAttribute.Size = new Size(282, 20);

                    Controls.Add(textAttribute);
                }

                if (item.Type == "LIST")
                {
                    ComboBox attributeComboBox = new ComboBox();

                    attributeComboBox.FormattingEnabled = true;
                    attributeComboBox.Location = new Point(149, height);
                    attributeComboBox.Name = "comboBox" + item.Attribute;
                    attributeComboBox.Size = new Size(171, 21);
                    attributeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    attributeComboBox.Tag = item;

                    var list = TemplateAttributeBLL.GetDataListAttribute(item.Id);
                    attributeComboBox.DataSource = list;
                    attributeComboBox.DisplayMember = "Value";
                    attributeComboBox.ValueMember = "Key";

                    Controls.Add(attributeComboBox);
                }
                
                height += 40; 
            }

            Button btnSave = new Button();

            btnSave.Location = new Point(149, (height + 45));
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.Text = "Gravar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new EventHandler(this.btnSave_Click);

            Controls.Add(btnSave);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(comboBoxPatient.SelectedValue.ToString());
            var patient = PatientBLL.GetPatientById(idPatient);

            var doctor = DoctorBLL.GetDoctorByUserId(FormParent.UserId);

            var patientRecord = PatientRecordBLL.GetPatientRecordByPatientId(patient.Id);

            if (patientRecord == null)
            {
                patientRecord = new PatientRecord();
                patientRecord.OpTempId = dataTemplate.Id;
                patientRecord.PatientId = patient.Id;
                patientRecord.DoctorId = doctor.Id;
                patientRecord.CreatedAt = DateTime.Now;

                patientRecord = PatientRecordBLL.AddPatientRecord(patientRecord);
            }

            var dataAttributeList = new List<Data>();
           
            foreach (var control in this.Controls)
            {
                var dataAttribute = new Data();
                
                if (control.GetType() == typeof(TextBox))
                {
                    var field = (TextBox)control;
                    var value = field.Text.ToString();

                    var tempAttr = (TemplateAttribute)field.Tag;
                    dataAttribute.TemplateAttributeId = tempAttr.Id;
                    dataAttribute.Value = value;
                    dataAttribute.PatientRecordId = patientRecord.Id;

                    TemplateAttributeBLL.AddDataAttribute(dataAttribute);
                }

                if (control.GetType() == typeof(ComboBox))
                {
                    var field = (ComboBox)control;

                    if (field.Name != "comboBoxPatient")
                    {
                        var value = field.SelectedValue.ToString();

                        var tempAttr = (TemplateAttribute)field.Tag;
                        dataAttribute.TemplateAttributeId = tempAttr.Id;
                        dataAttribute.Value = value;
                        dataAttribute.PatientRecordId = patientRecord.Id;

                        TemplateAttributeBLL.AddDataAttribute(dataAttribute);
                    }
                }

                
            }
        }
    }
}
