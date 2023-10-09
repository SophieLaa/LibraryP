using System.ComponentModel.DataAnnotations;

namespace Library.Web.ViewModels
{
    public class PublisherViewModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
