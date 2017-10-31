using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Manager")]
    public partial class Manager
    {
        public int Manager_ID { get; set; }

        [StringLength(25)]
        public string First_Name { get; set; }

        [StringLength(25)]
        public string Last_Name { get; set; }

        public string Phone { get; set; }

        [StringLength(125)]
        public string Email { get; set; }

        public virtual Manager Managers { get; set; }

        public virtual ICollection<Record_Details> RecordDetails { get; set; }
    }
}
