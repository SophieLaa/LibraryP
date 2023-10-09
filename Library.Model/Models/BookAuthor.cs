using System;


namespace Library.Web
{
    public partial class BookAuthor
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int AuthorID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
