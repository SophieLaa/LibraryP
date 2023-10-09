using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employees");
            HasKey(e => e.ID);

            Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            Property(e => e.LastName).IsRequired().HasMaxLength(50);
            Property(e => e.Address).HasColumnType("text");
            Property(e => e.Email).IsRequired().HasMaxLength(50);
            Property(e => e.PhoneNumber).IsRequired().HasMaxLength(50);
            Property(e => e.HireDate).HasColumnType("date");
            Property(e => e.Salary).HasColumnType("money");

            //HasOptional(e => e.User)
            //    .WithMany(u => u.Employees)
            //    .HasForeignKey(e => e.UserID)
            //    .WillCascadeOnDelete(false);

            HasMany(e => e.EmployeePositions)
                .WithRequired(ep => ep.Employee)
                .HasForeignKey(ep => ep.EmployeeID)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Reservations)
                .WithRequired(r => r.Employee)
                .HasForeignKey(r => r.EmployeeID)
                .WillCascadeOnDelete(false);

            //HasMany(e => e.Users)
            //    .WithOptional(u => u.Employee)
            //    .HasForeignKey(u => u.EmployeeID)
            //    .WillCascadeOnDelete(false);

        }
    }
}
