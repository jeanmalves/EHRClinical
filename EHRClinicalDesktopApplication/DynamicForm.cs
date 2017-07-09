using System;
using System.Drawing;
using System.Windows.Forms;

namespace EHRClinicalDesktopApplication
{
    public partial class DynamicForm : Form
    {
        public MainForm FormParent { get; private set; }
        public DynamicForm(MainForm formParent, object obj)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        private void DynamicForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            loadData();
        }

        private void loadData()
        {
            Label label = new Label();
            label.Location = new Point(33, 57);
            label.Size = new Size(144, 23);
            label.TabIndex = 0;
            label.Text = "Test ComboBox";
            Controls.Add(label);
        }
    }
}
