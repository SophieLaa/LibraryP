using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Web
{

    public partial class Shalf
    { 
        public int ID { get; set; }

        public int Floor { get; set; }

        [Required]
        [StringLength(50)]
        public string Room { get; set; }

        public int Shelf { get; set; }

        [Required]
        [StringLength(50)]
        public string Section { get; set; }

        [Required]
        [StringLength(50)]
        public string Row { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<BookShalf> BookShalves { get; set; }
    }
}
