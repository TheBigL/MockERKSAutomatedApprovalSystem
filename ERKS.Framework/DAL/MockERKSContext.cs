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
    }
}
