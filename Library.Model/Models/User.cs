using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Library.Web
{
    public class User
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        public int UserRoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public string VerificationCode { get; set; }

        public DateTime LastLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginLocation { get; set; }

        [Required]
        [StringLength(20)]
        public string IPAdress { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(50)]
        public string UserRoleTitle { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public virtual List<Employee> Employees { get; set; }

      //  public virtual Employee Employee { get; set; }

        public virtual UserRole UserRole { get; set; }

        
    }
}
