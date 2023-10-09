using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.ViewModels
{
    public class ManagerViewModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }

        [Required]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
    }
}
