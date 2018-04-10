using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SXPWDLib
{
    [ComVisible(true)]
    public interface ISXAuth
    {
        string GeneratePwdByName(string username);
    }
}
