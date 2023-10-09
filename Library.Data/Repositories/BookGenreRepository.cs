using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class BookGenressRepository : RepositoryBase<BookGenre>, IBookGenresRepository
    {
        public BookGenressRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IBookGenresRepository : IRepository<BookGenre>
    {

    }
}
