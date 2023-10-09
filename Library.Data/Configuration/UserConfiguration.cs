using Library.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Web;

public class UserConfiguration : EntityTypeConfiguration<User>
{
    public UserConfiguration()
    {
     
        ToTable("Users");
        
        Property(u => u.UserName).IsRequired().HasMaxLength(50);
        Property(u => u.Password).IsRequired().HasMaxLength(50);
        Property(u => u.LastLogin).IsRequired();
        Property(u => u.LoginLocation).IsRequired().HasMaxLength(50);
        Property(u => u.IPAdress).IsRequired().HasMaxLength(20);
        Property(u => u.RegistrationDate).IsRequired().HasColumnType("date");
        Property(u => u.IsActive).IsRequired();
        Property(u => u.UserRoleTitle).IsRequired().HasMaxLength(50);
        Property(u => u.CreateDate).IsRequired();
        Property(u => u.ChangeDate).IsRequired();
        Property(u => u.DeleteDate).IsRequired();

        
        //HasMany(u => u.Employees).WithRequired(e => e.User).HasForeignKey(e => e.UserID);
       // HasRequired(u => u.Employee).WithMany().HasForeignKey(u => u.EmployeeID);
        HasRequired(u => u.UserRole).WithMany().HasForeignKey(u => u.UserRoleID);
    }
}

