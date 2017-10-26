using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("LLD_ATS")]
    public partial class LLD_ATS
    {

        public int ATSID { get; set; }

        public int MeridianNumber { get; set; }

        public int RangeNumber { get; set; }

        public int TownshipNumber { get; set; }

        public int SectionNumber { get; set; }

        public int QuarterSectionNumber { get; set; }

        public int LSD { get; set; }

        
    }
}
