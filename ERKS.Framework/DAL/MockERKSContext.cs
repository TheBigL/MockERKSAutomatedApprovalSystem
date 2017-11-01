using ERKS.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERKS.Framework.DAL
{
    internal partial class MockERKSContext : DbContext
    {
        public MockERKSContext() : base("name=MockERKSDb")
        {

        }

        //TODO: Add the Dbset here
        public virtual DbSet<Site_File> Site_Files { get; set; }
        public virtual DbSet<Site_Address> Site_Addresses { get; set; }
        public virtual DbSet<Record_Details> Record_Details { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
    }
}
