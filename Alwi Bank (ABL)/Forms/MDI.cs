using System;
using System.IO;
using Alwi_Bank__ABL_.Forms;
using System.Windows.Forms;
using Alwi_Bank__ABL_.Classes;

namespace Alwi_Bank__ABL_
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        MainClass main = new MainClass();

        private void MDI_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(main.path + "\\connect"))
            {
                LoginForm loginForm = new LoginForm();
                loginForm.MdiParent = this;
                loginForm.WindowState = FormWindowState.Maximized;
                loginForm.Show();
            }
            else
            {
                SettingForm settingForm = new SettingForm();
                settingForm.MdiParent = this;
                settingForm.WindowState = FormWindowState.Maximized;
                settingForm.Show();
            }
        }
    }
}
