using System;


namespace Library.Web
{
    public partial class BookPublisher
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int PublisherID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
