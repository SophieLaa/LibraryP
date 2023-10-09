using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Web.App_Start
{
    public static class RoleInitializer
    {
        public static void InitializeRoles()
        {
            RoleManager roleManager = new RoleManager();
            roleManager.CreateRole("Admin");
            roleManager.CreateRole("Manager");
            roleManager.CreateRole("Guest");
            roleManager.CreateRole("Moderator");

           
            roleManager.AddUserToRole("admin@example.com", "Admin");
            roleManager.AddUserToRole("manager@example.com", "Manager");
            roleManager.AddUserToRole("guest@example.com", "Guest");
            roleManager.AddUserToRole("moderator@example.com", "Moderator");
        }
    }
}