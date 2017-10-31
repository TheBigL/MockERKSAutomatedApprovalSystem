using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using ERKS.Framework.Entities;

namespace ERKS.Framework.DAL
{
    public class MockERKSContext : DbContext
    {

                public MockERKSContext()
            : base("name=MockERKSDb")
        {}


    }
}
