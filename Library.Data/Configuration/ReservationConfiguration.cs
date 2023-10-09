using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            ToTable("Reservations");
            HasKey(r => r.ID);

            Property(r => r.ReservationDate).IsRequired().HasColumnType("date");
            Property(r => r.ResrvationStatus).IsRequired();
            Property(r => r.ExpirationDate).IsRequired().HasColumnType("date");
            Property(r => r.CreateDate).IsOptional();
            Property(r => r.ChangeDate).IsOptional();
            Property(r => r.DeleteDate).IsOptional();

            HasRequired(r => r.Book)
                .WithMany(b => b.Reservations)
                .HasForeignKey(r => r.BookID)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Member)
                .WithMany(m => m.Reservations)
                .HasForeignKey(r => r.MemberID)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Employee)
                .WithMany(e => e.Reservations)
                .HasForeignKey(r => r.EmployeeID)
                .WillCascadeOnDelete(false);

        }
    }
}
