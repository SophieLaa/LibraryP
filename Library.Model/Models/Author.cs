using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Library.Web
{
    public class Author
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }
        
        public virtual List<BookAuthor> BookAuthors { get; set; }
    }
}
