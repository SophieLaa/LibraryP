using System;


namespace Library.Web
{
    public partial class BookLanguage
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int LanguageID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Language Language { get; set; }
    }
}
