using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookLanguageConfiguration : EntityTypeConfiguration<BookLanguage>
    {
        public BookLanguageConfiguration()
        {
            ToTable("BookLanguages");
            HasKey(bl => bl.ID);

            HasRequired(bl => bl.Language)
                .WithMany(l => l.BookLanguages)
                .HasForeignKey(bl => bl.LanguageID)
                .WillCascadeOnDelete(false);

            HasRequired(bl => bl.Book)
                .WithMany(b => b.BookLanguages)
                .HasForeignKey(bl => bl.BookID)
                .WillCascadeOnDelete(false);

        }
    }
}
