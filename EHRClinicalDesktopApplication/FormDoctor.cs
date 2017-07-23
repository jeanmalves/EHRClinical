using Model.BLL;
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
    public partial class FormDoctor : Form
    {
        public MainForm FormParent { get; private set; }
        public FormDoctor(MainForm formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            loadData();
        }

        private void loadData()
        {
            if (FormParent.UserId > 0)
            {

                var doctor = DoctorBLL.GetDoctorByUserId(FormParent.UserId);
                
                var sexList = SexDictionary.SexList;
                SexComboBox.DataSource = new BindingSource(sexList, null);
                SexComboBox.DisplayMember = "Value";
                SexComboBox.ValueMember = "key";

                if (doctor != null)
                {
                    textFirstName.Text = doctor.FirstName;
                    textLastName.Text = doctor.LastName;
                    textBirth.Text = doctor.Birth.ToString("dd/MM/yyyy");

                    SexComboBox.SelectedValue = doctor.Sex;

                    textCRM.Text = doctor.MedicId.ToString();
                    textUserName.Text = doctor.User.UserName;
                    textEmail.Text = doctor.User.Email;
                }
               
                textFirstName.Enabled = false;
                textLastName.Enabled = false;
                textBirth.Enabled = false;
                SexComboBox.Enabled = false;
                textCRM.Enabled = false;
                textUserName.Enabled = false;
                textPassword.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textFirstName.Enabled = true;
            textLastName.Enabled = true;
            textBirth.Enabled = true;
            SexComboBox.Enabled = true;
            textCRM.Enabled = true;
            textUserName.Enabled = true;
            textPassword.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var firstName = textFirstName.Text.ToString();
            var lastName = textLastName.Text.ToString();
            var birth = textBirth.Text.ToString();
            var sex = Convert.ToInt32(SexComboBox.SelectedValue.ToString());
            var crm = textCRM.Text.ToString();
            var userName = textUserName.Text.ToString();
            var password = textPassword.Text.ToString();

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(birth) &&
                sex >= 0 && !string.IsNullOrEmpty(crm) && !string.IsNullOrEmpty(userName))
            {

                var doctor = DoctorBLL.GetDoctorByUserId(FormParent.UserId);

                doctor.FirstName = firstName;
                doctor.LastName = lastName;
                doctor.Birth = Convert.ToDateTime(birth);
                doctor.Sex = (short)sex;
                doctor.MedicId = Convert.ToInt32(crm);
                
                var update = DoctorBLL.UpdateDoctor(doctor);

                if (update)
                {
                    var user = new User();

                    user.Id = FormParent.UserId;
                    user.UserName = userName;
                
                    if (!string.IsNullOrEmpty(password))
                    {
                       user.Password = password;
                    }

                    var userUpdate = UserBLL.updateUser(user);

                    if (userUpdate)
                    {
                        MessageBox.Show("Os dados foram alterados.");
                    }
                    else
                    {
                        MessageBox.Show("Os dados de login não puderam ser alterados.");
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro ao alterar os dados.");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos.");
            }
        }
    }
}
