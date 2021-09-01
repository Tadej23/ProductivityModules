using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    [Table("tblProjects")]
    public class Projects
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public int BudgetSize { get; set; }
        public string Description { get; set; }
        //Foreign key
        public int TypeID { get; set; }




    }
}
