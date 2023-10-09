using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Web
{

    public partial class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string PublicationDate { get; set; }

        public int? Edition { get; set; }

        public int PageNumber { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

        public int ISBN { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<BookAuthor> BookAuthors { get; set; }

        public virtual List<BookGenre> BookGenres { get; set; }

        public virtual List<BookLanguage> BookLanguages { get; set; }

        public virtual List<BookPublisher> BookPublishers { get; set; }

        public virtual List<BookShalf> BookShalves { get; set; }

        public virtual List<Loan> Loans { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
