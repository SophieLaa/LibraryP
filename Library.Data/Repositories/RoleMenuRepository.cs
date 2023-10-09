using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class RoleMenuRepository : RepositoryBase<RoleMenu>, IRoleMenuRepository
    {
        public RoleMenuRepository(IDbFactory dbFactory)
            : base(dbFactory) { }


        public override void Update(RoleMenu entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IRoleMenuRepository : IRepository<RoleMenu>
    {
    
    }
}
