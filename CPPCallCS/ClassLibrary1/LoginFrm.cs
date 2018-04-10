using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SXPWD;

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
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool checkOK = CheckUserNamePwd(username, password);
            if (checkOK)
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

        public static bool CheckUserNamePwd(string username, string inputedPassword)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(inputedPassword))
            {
                return false;
            }

            string realPassword = Authentication.GeneratePasswordByName(username);
            bool retVal = inputedPassword == realPassword;
            return retVal;
        }

    }
}
