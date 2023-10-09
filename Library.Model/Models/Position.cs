using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Web
{

    public partial class Position
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PositionTitle { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<EmployeePosition> EmployeePositions { get; set; }
    }
}
