using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERKS.Framework.BLL.Security
{
    internal static class SecurityRoles
    {
        public const string WebAdmins = "WebAdmins";
        public const string Staff = "Staff";


        public static List<string> StartUpSecurityRoles
        {
            get
            {
                List<string> value = new List<string>();
                value.Add(WebAdmins);
                value.Add(Staff);
                return value;
            }
        }
    }
}
