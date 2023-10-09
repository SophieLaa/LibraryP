using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class BooksRepository : RepositoryBase<Book>, IBooksRepository
    {
        public BooksRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Book GetBookByName(string BookName)
        {
            var Book = this.DbContext.Books.Where(c => c.Title == BookName).FirstOrDefault();

            return Book;
        }


        public override void Update(Book entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IBooksRepository : IRepository<Book>
    {
        Book GetBookByName(string AuthorName);

    }
}
