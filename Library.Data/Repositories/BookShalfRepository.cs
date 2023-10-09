using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class BookShalvesRepository : RepositoryBase<BookShalf>, IBookShalvesRepository
    {
        public BookShalvesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IBookShalvesRepository : IRepository<BookShalf>
    {

    }
}