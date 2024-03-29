﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERKS.Framework.Entities.Security
{
    /// <summary>
    ///
    /// StaffID, OrganizationID, AdminID
    ///
    /// Username, Password, FirstName, LastName (if Applicable)
    ///Look at my DMIT2018 Final Project for more details
    /// 
    /// </summary>
    public class UserProfile
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int? StaffId { get; set; }
        public int? OrganizationId { get; set; }
        public int? AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> RoleMemberships { get; set; }





    }
}
