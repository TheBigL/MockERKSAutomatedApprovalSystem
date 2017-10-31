using ERKS.Framework.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERKS.Framework.BLL.Security
{
    [DataObject]
    public class UserManager : UserManager<ApplicationUser>
    {

        public UserManager()
            : base(new UserStore<ApplicationUser>(new MockERKSContext()))
        {

        }

        #region Constants
        private const string STR_DEFAULT_PASSWORD = "Pa$$word1";
        /// <summary>Requires FirstName and LastName</summary>
        private const string STR_USERNAME_FORMAT = "{0}.{1}";
        /// <summary>Requires UserName</summary>
        private const string STR_EMAIL_FORMAT = "{0}@ToolsRUs.tba";
        private const string STR_WEBMASTER_USERNAME = "Webmaster";
        #endregion

        
      



    }
}
