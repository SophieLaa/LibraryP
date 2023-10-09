using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class BookAuthorConfiguration : EntityTypeConfiguration<BookAuthor>
    {
        public BookAuthorConfiguration()
        {
            ToTable("BookAuthors");
            HasKey(ba => ba.ID);

            HasRequired(ba => ba.Author)
               .WithMany(a => a.BookAuthors)
               .HasForeignKey(ba => ba.AuthorID)
               .WillCascadeOnDelete(false);

            HasRequired(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookID)
                .WillCascadeOnDelete(false);


        }
    }
}