using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    //[Table("tblPerson")]
    public class Person
    {
        public int PersonID { get; set; }
        public int Name { get; set; }
        public int LastName { get; set; }
        
    }
}
