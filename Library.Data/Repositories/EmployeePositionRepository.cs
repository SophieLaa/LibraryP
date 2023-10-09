using Library.Data.Infrastructure;
using Library.Web;

namespace Library.Data.Repositories
{
    public class EmployeePositionsRepository : RepositoryBase<EmployeePosition>, IEmployeePositionsRepository
    {
        public EmployeePositionsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IEmployeePositionsRepository : IRepository<EmployeePosition> 
    {

    }
}