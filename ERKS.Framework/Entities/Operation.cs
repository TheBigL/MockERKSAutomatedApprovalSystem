using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Operation")]
   public partial class Operation
    {
        public int OperationId { get; set; }

        public string OperationName { get; set; }

        public string Description { get; set; }
    }
}
