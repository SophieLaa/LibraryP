using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Web
{
    public class Role
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<RoleMenu> RoleMenus { get; set; }

        public virtual List<UserRole> UserRoles { get; set; } 
    }
}

