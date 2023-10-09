using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory)
            : base(dbFactory) { }


        public override void Update(Menu entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IMenuRepository : IRepository<Menu>
    {
        
    }
}
