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
    public class UserRolesRepository : RepositoryBase<UserRole>, IUserRolesRepository
    {
        public UserRolesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public User GetUserByUsername(string username)
        {
            return DbContext.Users.FirstOrDefault(u => u.UserName == username);
        }
    }

    public interface IUserRolesRepository : IRepository<UserRole>
    {
        //UserRole GetRoleByTitle(string title);
        User GetUserByUsername(string username);
    }
}
