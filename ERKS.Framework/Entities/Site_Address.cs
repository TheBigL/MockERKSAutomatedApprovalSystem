using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Site_Address")]
    public partial class Site_Address
    {
        public int Location_Code { get; set; }

        public int ATS_ID { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Postal_Code { get; set; }
    }
}
