using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
namespace DataModel
{
    [Table("tblPublications")]
    public class Publications
    {
        public int PublicationId { get; set; }

    }
}
