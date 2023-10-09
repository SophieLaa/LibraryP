using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Web
{


    public partial class EmployeePosition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int PositionID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Position Position { get; set; }
    }
}
