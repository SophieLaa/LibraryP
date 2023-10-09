using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class BookAuthorsRepository : RepositoryBase<BookAuthor>, IBookAuthorsRepository
    {
        public BookAuthorsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IBookAuthorsRepository : IRepository<BookAuthor>
    {

    }
}

