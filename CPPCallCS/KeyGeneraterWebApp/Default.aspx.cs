using SXPWDLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeyGeneraterWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generatePassButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            if (String.IsNullOrEmpty(username))
            {
                passwordTextBox.Text = "Please input user name.";
                return;
            }
            string password = Authentication.GeneratePasswordByName(username);
            passwordTextBox.Text = password;

        }
    }
}