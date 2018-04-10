using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClassLibrary1
{
    [ComVisible(true)]
    public class MyClass1 : IMyInterface1
    {
        public bool Login()
        {
            bool result = false;

            // Call custom login dialog
            LoginFrm loginDlg = new LoginFrm();
            result = (loginDlg.ShowDialog() == DialogResult.OK);

            return result;
        }
    }
}
