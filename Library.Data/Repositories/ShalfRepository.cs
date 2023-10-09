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
    public class ShalvesRepository : RepositoryBase<Shalf>, IShalvesRepository
    {
        public ShalvesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IShalvesRepository : IRepository<Shalf>
    {

    }
}
