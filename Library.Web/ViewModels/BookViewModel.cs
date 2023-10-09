using System;
using System.ComponentModel.DataAnnotations;
using Library.Service;

namespace Library.Web.ViewModels
{
    public class BookViewModel
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
    }
}
