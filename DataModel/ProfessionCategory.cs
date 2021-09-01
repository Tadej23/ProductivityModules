using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    [Table("tblProfessionCategory")]
    public class ProfessionCategory
    {
        public int ProfessionCategoryID { get; set; }
        public string Title { get; set; }
    }
}
