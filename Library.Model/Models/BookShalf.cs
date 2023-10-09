using System;

namespace Library.Web
{
    public partial class BookShalf
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int ShelfID { get; set; }

        public int BookQuantity { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Shalf Shalf { get; set; }
    }
}
