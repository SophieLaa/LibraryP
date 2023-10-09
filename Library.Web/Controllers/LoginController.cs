using Library.Service;
using Library.Web.ViewModels;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["RegistrationSuccess"] != null && (bool)TempData["RegistrationSuccess"])
            {
                ViewBag.RegistrationMessage = "Registration successful. You can now log in.";
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(LogInViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_loginService.AuthenticateUser(model.Username, model.Password))
                {
                    return RedirectToAction("Welcome", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }

            return View(model);
        }
    }
}


