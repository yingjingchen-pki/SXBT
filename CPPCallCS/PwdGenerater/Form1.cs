using SXPWDLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdGenerater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generatePwdButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input user name.");
                return;
            }
            string password = Authentication.GeneratePasswordByName(username);
            passwordTextbox.Text = password;
        }
    }
}
