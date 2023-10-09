using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookPublisherConfiguration : EntityTypeConfiguration<BookPublisher>
    {
        public BookPublisherConfiguration()
        {
            ToTable("BookPublishers");
            HasKey(bp => bp.ID);

            HasRequired(bp => bp.Publisher)
                .WithMany(p => p.BookPublishers)
                .HasForeignKey(bp => bp.PublisherID)
                .WillCascadeOnDelete(false);

            HasRequired(bp => bp.Book)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp => bp.BookID)
                .WillCascadeOnDelete(false);

        }
    }
}
