using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Officer")]
    public partial class Officer
    {
        public int Officer_ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
