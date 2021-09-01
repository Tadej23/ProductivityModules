using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblProjectPerson")]
    public class ProjectPerson
    {
        public bool IsLeader { get; set; }
    }
}
