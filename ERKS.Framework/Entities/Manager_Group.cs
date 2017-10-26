using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Manager_Group")]
    public partial class Manager_Group
    {
        public int Manager_Group_ID { get; set; }

        public int Manager_ID { get; set; }

        public string Manager_Group_Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Manager_Group> ManagerGroup { get; set; }
    }
}
