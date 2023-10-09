using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

       

        public User GetUserByEmployeeID(int EmployeeID)
        {
            var user = this.DbContext.Users.FirstOrDefault(c => c.EmployeeID == EmployeeID);
            return user;
        }

        public User GetUserByUserRoleID(int UserRoleID)
        {
            var user = this.DbContext.Users.FirstOrDefault(c => c.UserRoleID == UserRoleID);
            return user;
        }

        public User GetUserByUserName(string UserName)
        {
            var user = this.DbContext.Users.FirstOrDefault(c => c.UserName == UserName);
            return user;
        }

        public User GetUserByUserRoleTitle(string UserRoleTitle)
        {
            var user = this.DbContext.Users.FirstOrDefault(c => c.UserRoleTitle == UserRoleTitle);
            return user;
        }

        public override void Update(User entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }

        public void AddUser(User newUser)
        {
            this.DbContext.Users.Add(newUser);
        }

        public void Save()
        {
            this.DbContext.SaveChanges();
        }

        public object GetUserByUsername(string userName)
        {
            var user = this.DbContext.Users.FirstOrDefault(c => c.UserName == userName);
            return user;
        }

        public object GetUsersInRole(string role)
        {

            var usersInRole = this.DbContext.Users.Where(u => u.UserRoleTitle == role).ToList();
            return usersInRole;
        }
    }

    public interface IUsersRepository : IRepository<User>
    {
        User GetUserByEmployeeID(int EmployeeID);
        User GetUserByUserRoleID(int UserRoleID);
        User GetUserByUserName(string UserName);
        User GetUserByUserRoleTitle(string UserRoleTitle);
        void AddUser(User newUser);
        void Save();
        object GetUsersInRole(string role);
    }
}
