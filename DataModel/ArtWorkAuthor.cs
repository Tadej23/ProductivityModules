using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblArtWorkAuthor")]
    public class ArtWorkAuthor
    {
        public int AuthorType { get; set; }
    }
}
