using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Web
{
    public partial class Language
    {
        public int ID { get; set; }

        [Column("Language", TypeName = "text")]
        [Required]
        public string Language1 { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<BookLanguage> BookLanguages { get; set; }
    }
}
