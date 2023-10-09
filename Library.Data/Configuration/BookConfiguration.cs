using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            ToTable("Books");
            Property(b => b.Title).IsRequired().HasMaxLength(200);
            Property(b => b.PublicationDate).IsRequired().HasMaxLength(100);
            Property(b => b.Edition).IsOptional();
            Property(b => b.PageNumber).IsRequired();
            Property(b => b.TotalCopies).IsRequired();
            Property(b => b.AvailableCopies).IsRequired();
            Property(b => b.ISBN).IsRequired();
        }
    }
}
