using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class PenaltyConfiguration : EntityTypeConfiguration<Penalty>
    {
        public PenaltyConfiguration()
        {
            ToTable("Penalties");
            HasKey(p => p.ID);

            Property(p => p.PenaltyDate).HasColumnType("date").IsRequired();
            Property(p => p.PenaltyAmount).HasColumnType("money").IsRequired();
            Property(p => p.PaymentStatus).IsRequired().HasMaxLength(50);
            Property(p => p.CreateDate).IsRequired();
            Property(p => p.ChangeDate).IsRequired();
            Property(p => p.DeleteDate).IsRequired();

            HasRequired(p => p.Loan)
                .WithMany(l => l.Penalties)
                .HasForeignKey(p => p.LoanID);

            HasRequired(p => p.Member)
                .WithMany(m => m.Penalties)
                .HasForeignKey(p => p.MemberID);

        }
    }
}
