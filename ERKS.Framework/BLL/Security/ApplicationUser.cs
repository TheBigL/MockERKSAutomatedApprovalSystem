using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERKS.Framework.BLL.Security
{
    public class ApplicationUser : IdentityUser
    {
        public int AdminId { get; set; }
        public int StaffId { get; set; }

    }
}
