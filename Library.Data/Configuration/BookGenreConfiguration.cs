using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookGenreConfiguration : EntityTypeConfiguration<BookGenre>
    {
        public BookGenreConfiguration()
        {
            ToTable("BookGenres");
            HasKey(bg => bg.ID);

            HasRequired(bg => bg.Genre)
                .WithMany(g => g.BookGenres)
                .HasForeignKey(bg => bg.GenreID)
                .WillCascadeOnDelete(false);

            HasRequired(bg => bg.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.BookID)
                .WillCascadeOnDelete(false);

        }
    }
}
