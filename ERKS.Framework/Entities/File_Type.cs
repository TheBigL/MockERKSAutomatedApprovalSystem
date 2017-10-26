using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("File_Type")]
    public partial class File_Type
    {
        public int Type_ID { get; set; }

        public string Type_Description { get; set; }

        public virtual ICollection<Site_File> SiteFile { get; set; }
    }
}
