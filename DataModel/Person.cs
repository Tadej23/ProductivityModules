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
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public bool Gender { get; set; }

    }
}
