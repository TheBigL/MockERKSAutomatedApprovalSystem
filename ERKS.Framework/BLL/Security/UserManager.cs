using ERKS.Framework.DAL;
using ERKS.Framework.Entities.Security;
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

        #region User CRUD
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<UserProfile> ListAllUsers()
        {
            var rm = new RoleManager();
            var result = from person in Users.ToList()
                         select new UserProfile()
                         {
                             UserId = person.Id,
                             UserName = person.UserName,
                             Email = person.Email,
                             EmailConfirmed = person.EmailConfirmed,
                             OrganizationId = person.OrganizationId,
                             StaffId = person.StaffId,
                             AdminId = person.AdminId,
                             RoleMemberships = person.Roles.Select(r => rm.FindById(r.RoleId).Name)
                         };
            
            using(var context = new MockERKSContext())
            {
                foreach(var person in result)
                {
                    //TODO: Finish the MockERKSDatabaseContext class before I can finish this method. 
                    //person.FirstName = context.
                }
            }

            return result.ToList();
             


        }


        #endregion

    }
}
