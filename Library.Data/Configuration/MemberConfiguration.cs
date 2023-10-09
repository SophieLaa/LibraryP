using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            ToTable("Members");
            HasKey(m => m.ID);

            Property(m => m.FirstName).IsRequired().HasMaxLength(50);
            Property(m => m.LastName).IsRequired().HasMaxLength(50);
            Property(m => m.JoinedDate).IsRequired().HasColumnType("date");
            Property(m => m.ActiveStatus).IsRequired();
            Property(m => m.Adress).HasMaxLength(50); 
            Property(m => m.Email).HasMaxLength(50);
            Property(m => m.PhoneNumber).IsRequired().HasMaxLength(50);
            Property(m => m.IsDeleted).IsRequired();
            Property(m => m.CreateDate).IsRequired();
            Property(m => m.ChangeDate).IsRequired();
            Property(m => m.DeleteDate).IsRequired();

            HasMany(m => m.Loans)
                .WithRequired(l => l.Member)
                .HasForeignKey(l => l.MemberID)
                .WillCascadeOnDelete(false);

            HasMany(m => m.Penalties)
                .WithRequired(p => p.Member)
                .HasForeignKey(p => p.MemberID)
                .WillCascadeOnDelete(false);

            HasMany(m => m.Reservations)
                .WithRequired(r => r.Member)
                .HasForeignKey(r => r.MemberID)
                .WillCascadeOnDelete(false);
        }
    }
}
