using Library.Data;
using Library.Web;
using System.Linq;
using System.Web.Mvc;

public class RoleController : Controller
{
    private readonly StoreEntities _dbContext;

    public RoleController(StoreEntities dbContext)
    {
        _dbContext = dbContext;
    }

    public ActionResult InitializeRoles()
    {
        InitializeRole("Admin");
        InitializeRole("Manager");
        InitializeRole("Guest");
        InitializeRole("Moderator");

        AssignRoleToUser("admin@example.com", "Admin");
        AssignRoleToUser("manager@example.com", "Manager");
        AssignRoleToUser("guest@example.com", "Guest");
        AssignRoleToUser("moderator@example.com", "Moderator");

        return Content("Roles initialized successfully.");
    }

    private void InitializeRole(string roleTitle)
    {
        if (!_dbContext.UserRoles.Any(r => r.RoleTitles == roleTitle))
        {
            var role = new UserRole { RoleTitles = roleTitle };
            _dbContext.UserRoles.Add(role);
            _dbContext.SaveChanges();
        }
    }

    private void AssignRoleToUser(string userName, string roleTitle)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.UserName == userName);
        var role = _dbContext.UserRoles.FirstOrDefault(r => r.RoleTitles == roleTitle);

        if (user != null && role != null)
        {
            user.ID = role.ID;
            _dbContext.SaveChanges();
        }
    }
}

