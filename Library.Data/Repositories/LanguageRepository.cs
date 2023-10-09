using Library.Data.Infrastructure;
using Library.Web;
using System.Linq;

namespace Library.Data.Repositories
{
    public class LanguagesRepository : RepositoryBase<Language>, ILanguagesRepository
    {
        public LanguagesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
        public Language GetBookByLanguage(string Language)
        {
            var Languages = this.DbContext.Languages.Where(x => x.Language1 == Language).FirstOrDefault();
            return Languages;
        }
    }

    public interface ILanguagesRepository : IRepository<Language>
    {
        Language GetBookByLanguage(string Language);

    }
}