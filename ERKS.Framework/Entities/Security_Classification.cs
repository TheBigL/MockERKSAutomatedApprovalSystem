using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERKS.Framework.Entities
{
    [Table("Security_Classification")]
    public partial class Security_Classification
    {
        public int Security_Classification_ID { get; set; }

        public string Security_Classification_Name { get; set; }

        public string Security_Classification_Description { get; set; }
    }
}
