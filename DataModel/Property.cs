using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblProperty")]
    public class Property
    {
        public int PropertyID { get; set; }
        public string Name { get; set; }
    }

}
