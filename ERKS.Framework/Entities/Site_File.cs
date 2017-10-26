using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Site_File")]
    public partial class Site_File
    {
        public int File_ID { get; set; }

        public int Type_ID { get; set; }

        public int Operation_ID { get; set; }

        public int PBL_ID { get; set; }

        public int Category_ID { get; set; }

        public int LINC_Number { get; set; }

        public int Organization_ID { get; set; }

        public int Document_Type_ID { get; set; }

        public int Security_Classification_ID { get; set; }

        public string File_Status { get; set; }

        public DateTime? Closed_Date { get; set; }
    }
}
