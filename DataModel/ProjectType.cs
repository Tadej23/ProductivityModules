﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    [Table("tblProjectType")]
    public class ProjectType
    {
        public int ProjectTypeID { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
    }
}
