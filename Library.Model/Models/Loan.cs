using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Web
{
    public partial class Loan
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int MemberID { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime LoanDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }

        public int OverdueDays { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Member Member { get; set; }

        public virtual List<Penalty> Penalties { get; set; }
    }
}
