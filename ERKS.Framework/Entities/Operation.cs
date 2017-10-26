using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Operation")]
   public partial class Operation
    {
        public int Operation_ID { get; set; }

        public string Operation_Name { get; set; }

        public string Description { get; set; }
    }
}
