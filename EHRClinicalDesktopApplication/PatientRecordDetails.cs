using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHRClinicalDesktopApplication
{
    public partial class PatientRecordDetails : Form
    {
        public PatientRecord PatientRecord { get; set; }
        public PatientRecordDetails(PatientRecord patientRecord)
        {
            InitializeComponent();

            PatientRecord = patientRecord;
        }

        private void PatientRecordDetails_Load(object sender, EventArgs e)
        {
            dateValue.Text = PatientRecord.CreatedAt.ToString();
            patientValue.Text = PatientRecord.Patient.FirstName + " " + PatientRecord.Patient.LastName;
            doctorValue.Text = PatientRecord.Doctor.FirstName + " " + PatientRecord.Doctor.LastName;
            templateNameValue.Text = PatientRecord.OperationalsTemplate.Name;

            int height = 200;

            foreach (var item in PatientRecord.Data)
            {
                Label attributeLabel = new Label();

                attributeLabel.Location = new Point(40, height);
                attributeLabel.Name = "lbl" + item.TemplateAttribute.Attribute;
                attributeLabel.Text = item.TemplateAttribute.Attribute;
                attributeLabel.UseCompatibleTextRendering = true;
                attributeLabel.Size = new Size(180, 20);

                Controls.Add(attributeLabel);


                TextBox textAttribute = new TextBox();

                textAttribute.Location = new Point(220, height);
                textAttribute.Name = "text" + item.TemplateAttribute.Attribute;
                textAttribute.Text = item.Value;
                textAttribute.Size = new Size(282, 20);
                textAttribute.Enabled = false;
                textAttribute.ReadOnly = true;
                
                Controls.Add(textAttribute);

                height += 30;
            }

           /* Label label = new Label();
            label.Location = new Point(33, 24);
            label.Size = new Size(144, 23);
            label.Text = PatientRecord.OperationalsTemplate.Name;
            Controls.Add(label);

            int height = 110;

            Label CreatedAtLabel = new Label();

            CreatedAtLabel.Location = new Point(39, height);
            CreatedAtLabel.Name = "lblCreatedAt";
            CreatedAtLabel.Text = "Data:";
            CreatedAtLabel.UseCompatibleTextRendering = true;

            Controls.Add(CreatedAtLabel);

            Label CreatedAtValue = new Label();

            CreatedAtValue.Location = new Point(149, height);
            CreatedAtValue.Name = "lblCreatedAtValue";
            CreatedAtValue.Text = PatientRecord.CreatedAt.ToString();
            CreatedAtValue.UseCompatibleTextRendering = true;

            Controls.Add(CreatedAtValue);

            Label PatientLabel = new Label();

            PatientLabel.Location = new Point(149, height);
            PatientLabel.Name = "lblPatientLabel";
            PatientLabel.Text = "Paciente:";
            PatientLabel.UseCompatibleTextRendering = true;

            Controls.Add(PatientLabel);
            */



        }
    }
}
