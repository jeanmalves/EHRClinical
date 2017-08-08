using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        public void ShowMenu(string menu, List<Feature> features)
        {
            if (menu == "menuLoged")
            {
                foreach (var item in features)
                {
                    var menuStripItem = new ToolStripMenuItem(item.Name);

                    menuStripItem.Name = item.Name;
                    menuStripItem.Tag = item.OperationalsTemplate;

                    if (item.OperationalsTemplate.Name == "Profile")
                    {
                        menuStripItem.Click += new EventHandler(ProfileStripMenuItem_Click);
                    }
                    else
                    {
                        menuStripItem.Click += new EventHandler(MenuItemClick);
                    }

                    menuLoged.Items.Add(menuStripItem);
                }

                var sairStripMenuItem = new ToolStripMenuItem("sairStripMenuItem");

                sairStripMenuItem.Name = "sairStripMenuItem";
                sairStripMenuItem.Text = "Sair";
                sairStripMenuItem.Click += new EventHandler(sairToolStripMenuItem_Click);

                menuLoged.Items.Add(sairStripMenuItem);
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

            menuLoged.Items.Clear();
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

        private void ProfileStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveWindow();

            var doctorRole = RoleGroupBLL.GetRoleGroupByRole("DOCTOR");

            if (RoleUser == doctorRole.Id)
            {
                FormDoctor formDoctor = new FormDoctor(this);
                formDoctor.MdiParent = this;
                formDoctor.Show();
            }
        }

        private void MenuItemClick(object sender, EventArgs e)
        {
            string sFormName = ((ToolStripMenuItem)sender).Name.ToString();
            
            var opt = (OperationalsTemplate) ((ToolStripMenuItem)sender).Tag;

            if (opt.IsController == 1)
            {
                Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

                foreach (Type type in frmAssembly.GetTypes())
                {
                    if (type.BaseType == typeof(Form))
                    {
                        if (type.Name == opt.Template)
                        {
                            object[] args = new object[] { this };

                            Form frmShow = (Form)frmAssembly.CreateInstance(
                                                                    type.ToString(),
                                                                    false,
                                                                    BindingFlags.CreateInstance,
                                                                    null,
                                                                    args,
                                                                    null,
                                                                    null);
                            
                            foreach (Form form in this.MdiChildren)
                            {
                                form.Close();
                            }

                            frmShow.MdiParent = this;
                            frmShow.WindowState = FormWindowState.Maximized;
                            frmShow.Show();
                        }
                    }
                }
            }
            else
            {
                var dynamicForm = new DynamicForm(this, opt);
                dynamicForm.MdiParent = this;
                dynamicForm.Show();
            }

        }
    }
}
