using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Web
{


    public partial class Penalty
    {
        public int ID { get; set; }

        public int MemberID { get; set; }

        public int LoanID { get; set; }

        [Column(TypeName = "date")]
        public DateTime PenaltyDate { get; set; }

        [Column(TypeName = "money")]
        public decimal PenaltyAmount { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual Member Member { get; set; }
    }
}
