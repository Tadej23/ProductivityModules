using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblCitationSources")]
    public class CitationSources
    {
        public int CitationSourceID { get; set; }
        public string Name { get; set; }
    }
}
