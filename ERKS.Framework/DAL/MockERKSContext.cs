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
<<<<<<< HEAD
             public MockERKSContext()
            : base("name=MockERKS")
=======
        public MockERKSContext()
            : base("name=MockERKSDb")
>>>>>>> fdbb41b1e45ff0640de4e839d625a0b96386ffe5
        {
        }

    }
}
