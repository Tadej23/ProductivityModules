using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblPublicationAuthor")]
    public class PublicationAuthor
    {
        public int AuthorType { get; set; }
    }
}
