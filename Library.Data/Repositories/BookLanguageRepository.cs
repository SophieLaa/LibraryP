using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class BookLanguagesRepository : RepositoryBase<BookLanguage>, IBookLangaugesRepository
    {
        public BookLanguagesRepository(IDbFactory dbFactory)
        : base(dbFactory) { }
    }

    public interface IBookLangaugesRepository : IRepository<BookLanguage>
    {

    }
}
