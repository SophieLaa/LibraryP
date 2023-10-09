using System.ComponentModel.DataAnnotations;

namespace Library.Web.ViewModels
{
    public class PositionViewModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PositionTitle { get; set; }
    }
}
