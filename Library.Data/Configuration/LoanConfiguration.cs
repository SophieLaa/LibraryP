using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
        {
            ToTable("Loans");
            HasKey(l => l.ID);

            Property(l => l.LoanDate).HasColumnType("date").IsRequired();
            Property(l => l.DueDate).HasColumnType("date").IsRequired();
            Property(l => l.ReturnDate).HasColumnType("date");

          
            HasRequired(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookID)
                .WillCascadeOnDelete(false);

            HasRequired(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberID)
                .WillCascadeOnDelete(false);
          
        }
    }
}
