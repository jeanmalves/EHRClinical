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
    public partial class MainForm : Form
    {
        private bool logedUser = false;

        public bool LogedUser
        {
            get { return logedUser ; }
            set { logedUser  = value; }
        }

        public string UserName { get;  set; }

        public string UserEmail { get;  set; }

        public int UserId { get; set; }

        public int RoleUser { get;  set; }

        public MainForm()
        {
            InitializeComponent();

            if (!LogedUser)
            {
                OpenLoginWindow();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        public void SetLoginUser()
        {
            LogedUser = true;
        }

        public void HiddenMenu(String menu)
        {
            if (menu == "menuLoged")
            {
                menuLoged.Visible = false;
            }
        }

        public void ShowMenu(String menu)
        {
            if (menu == "menuLoged")
            {
                menuLoged.Visible = true;
            }
        }

        public void CloseActiveWindow()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        public void logoff()
        {
            LogedUser = false;
            UserId = 0;
            UserName = string.Empty;
            UserEmail = string.Empty;
            RoleUser = 0;
        }

        public void CloseWindows()
        {
            if (MdiChildren.Length > 0)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
            }
        }

        public void OpenLoginWindow()
        {
            CloseActiveWindow();
            LoginForm login = new LoginForm(this);
            login.MdiParent = this;
            login.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoff();

            if (this.MdiChildren.Length > 0)
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }

            HiddenMenu("menuLoged");

            LoginForm login = new LoginForm(this);
            login.MdiParent = this;
            login.Show();

        }
    }
}
