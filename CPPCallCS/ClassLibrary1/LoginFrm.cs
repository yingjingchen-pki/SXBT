using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "cyj" && PasswordTextBox.Text == "123456")
            {
                DialogResult = DialogResult.OK;
            }
            else if (UserNameTextBox.Text == "cyj1" && PasswordTextBox.Text == "123456")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("User Name or Password is wrong.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
