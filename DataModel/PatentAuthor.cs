using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    [Table("tblPatentAuthor")]
    public class PatentAuthor
    {
        public int AuthorType { get; set; }
    }
}
