using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class BookPublishersRepository : RepositoryBase<BookPublisher>, IBookPublishersRepository
    {
        public BookPublishersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IBookPublishersRepository : IRepository<BookPublisher>
    {

    }
}
