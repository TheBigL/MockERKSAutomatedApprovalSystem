using Microsoft.AspNet.Identity.EntityFramework;

namespace ERKS.Framework.BLL.Security
{
    public class ApplicationUser : IdentityUser
    {
        public int? AdminId { get; set; }
        public int? StaffId { get; set; }

        public int? OrganizationId { get; set; }

    }
}
