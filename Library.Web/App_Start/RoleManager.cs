using Library.Web;
using System.Collections.Generic;
using System;

public class RoleManager
{
    private List<UserRole> roles = new List<UserRole>();

    public void CreateRole(string roleName)
    {
        roles.Add(new UserRole { ID = roles.Count + 1, RoleTitles = roleName, Users = new List<User>() });
    }

    public void AddUserToRole(string userName, string roleName)
    {
        var role = roles.Find(r => r.RoleTitles == roleName);
        if (role != null)
        {
            User user = new User { UserName = userName, Password = "password" }; 
        }
    }

    public void DisplayUsersInRole(string roleName)
    {
        var role = roles.Find(r => r.RoleTitles == roleName);
        if (role != null)
        {
            Console.WriteLine($"Users in {role.RoleTitles} role:");
            foreach (var user in role.Users)
            {
                Console.WriteLine($"- {user.UserName}");
            }
        }
    }

    public void AssignRoleToUser(string userName, string roleName)
    {
        var user = FindUser(userName);
        var role = roles.Find(r => r.RoleTitles == roleName);

        if (user != null && role != null)
        {
            role.Users.Add(user);
            Console.WriteLine($"Assigned {roleName} role to user: {userName}");
        }
        else
        {
            Console.WriteLine($"User {userName} or role {roleName} not found.");
        }
    }

    public void DisplayAllRoles()
    {
        Console.WriteLine("Available roles:");
        foreach (var role in roles)
        {
            Console.WriteLine($"- {role.RoleTitles}");
        }
    }

    private User FindUser(string userName)
    {
        foreach (var role in roles)
        {
            var user = role.Users.Find(u => u.UserName == userName);
            if (user != null)
            {
                return user;
            }
        }
        return null;
    }

    
}