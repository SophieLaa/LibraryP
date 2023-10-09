using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Library.Web
{
    public class UserRole
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleTitles { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
