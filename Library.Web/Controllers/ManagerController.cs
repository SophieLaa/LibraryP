using Library.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IUserService userService;

        public ManagerController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult ListManagers()
        {
            IEnumerable<User> managers = (IEnumerable<User>)userService.GetUsersInRole("Manager");

            return View(managers);
        }
    }
}
