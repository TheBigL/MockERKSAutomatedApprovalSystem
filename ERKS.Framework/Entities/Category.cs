using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Category")]
    public partial class Category
    {
        public int Category_ID { get; set; }

        [StringLength(25)]
        public string Category_Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Site_File> SiteFile { get; set; }
    }
}
