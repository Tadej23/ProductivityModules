using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblPatents")]
    public class Patents
    {
        public int PatentID { get; set; }
    }
}
