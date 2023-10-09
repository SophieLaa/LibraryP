using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Web
{
    public partial class Genre
    {
        public int ID { get; set; }

        [Column(TypeName = "text")]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }
        public virtual List<BookGenre> BookGenres { get; set; }
    }
}
