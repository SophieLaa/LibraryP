using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookShalfConfiguration : EntityTypeConfiguration<BookShalf>
    {
        public BookShalfConfiguration()
        {
            ToTable("BookShalves");
            HasKey(bs => bs.ID);

           
            HasRequired(bs => bs.Shalf)
                .WithMany(s => s.BookShalves)
                .HasForeignKey(bs => bs.ShelfID)
                .WillCascadeOnDelete(false);

            HasRequired(bs => bs.Book)
                .WithMany(b => b.BookShalves)
                .HasForeignKey(bs => bs.BookID)
                .WillCascadeOnDelete(false);

        }
    }
}
