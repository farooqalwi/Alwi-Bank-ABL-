using Alwi_Bank__ABL_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alwi_Bank__ABL_.Forms
{
    public partial class SettingForm : Sample
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        MainClass mainClass = new MainClass();

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (isCB.Checked)
            {
                if (txtDataSource.Text == "" || txtDatabase.Text == "")
                {
                    MessageBox.Show("Some Fields are empty.");
                }
                else
                {
                    stringBuilder.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(mainClass.path + "\\connect", stringBuilder.ToString());
                    DialogResult dialogResult = MessageBox.Show("Settings saved succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult==DialogResult.OK)
                    {
                        LoginForm loginForm = new LoginForm();
                        mainClass.ShowWindow(loginForm, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (txtDataSource.Text == "" || txtDatabase.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Some Fields are empty.");
                }
                else
                {
                    stringBuilder.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(mainClass.path + "\\connect", stringBuilder.ToString());
                    DialogResult dialogResult = MessageBox.Show("Settings saved succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        LoginForm loginForm = new LoginForm();
                        mainClass.ShowWindow(loginForm, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                txtUsername.Text = "";
                txtUsername.Enabled = false;
                txtPassword.Text = "";
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}
