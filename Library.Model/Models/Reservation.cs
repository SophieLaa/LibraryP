using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Web
{
    public partial class Reservation
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int MemberID { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReservationDate { get; set; }

        public int ResrvationStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ChangeDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Member Member { get; set; }
    }
}
