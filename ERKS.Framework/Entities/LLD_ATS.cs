namespace ERKS.Framework.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LLD_ATS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public int ATSID { get; set; }
        public int MeridianNumber { get; set; }
        public int RangeNumber { get; set; }
        public int TownshipNumber { get; set; }
        public int SectionNumber { get; set; }
        public int QuarterSectionNumber { get; set; }
        public int LSD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    }
}
