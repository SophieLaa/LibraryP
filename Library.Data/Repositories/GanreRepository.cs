using Library.Data.Infrastructure;
using Library.Model;
using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class GenresRepository : RepositoryBase<Genre>, IGenresRepository
    {
        public GenresRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
        public Genre GetGenreByName(string GenreName)
        {
            var Genre = this.DbContext.Genres.Where(x => x.Name == GenreName).FirstOrDefault();
            return Genre;
        }
    }

    public interface IGenresRepository : IRepository<Genre>
    {
        Genre GetGenreByName(string GenreName);

    }
}
