using Library.Web;
using System.Collections.Generic;

namespace Library.Service
{
    public interface IUserService
    {
        bool ValidateUser(string username, string password);
        bool RegisterUser(User user);
        bool UserExists(string username);
        IEnumerable<object> GetUsersInRole(string v);
    }
}
