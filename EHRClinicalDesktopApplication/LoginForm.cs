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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EHRClinicalDesktopApplication
{
    public partial class LoginForm : Form
    {
        public MainForm FormParent { get; private set; }

        public LoginForm(MainForm formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textUser.Text) && !string.IsNullOrEmpty(textPassword.Text))
            {
                User user = new User();

                var role = RoleGroupBLL.GetRoleGroupByRole("DOCTOR");

                user.UserName = textUser.Text;
                user.Password = textPassword.Text;
                user.RoleGroupID = role.Id;

                var logedUser = UserBLL.Authenticate(user);
                
                if (logedUser != null)
                {
                    FormParent.SetLoginUser();

                    var features = FeatureBLL.GetFeaturesByRole(role.Id);
                    
                    FormParent.ShowMenu("menuLoged", features);

                    FormParent.UserId = logedUser.Id;
                    FormParent.UserEmail = logedUser.Email;
                    FormParent.UserName = logedUser.UserName;
                    FormParent.RoleUser = logedUser.RoleGroupID;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Um ou mais campos preenchidos estão incorretos ou o usuário não está ativo.");
                }

            }
            else
            {
                MessageBox.Show("É preciso informar um usuário, senha e selecionar o tipo.");
            }

        }
    }
}
