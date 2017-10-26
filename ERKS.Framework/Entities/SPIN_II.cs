using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("SPIN_II")]
    public partial class SPIN_II
    {
        public int LINC_Number { get; set; }

        public string Street_Range { get; set; }

        public string Avenue_Range { get; set; }
    }
}
