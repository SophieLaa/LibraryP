using Library.Service;
using Library.Web.ViewModels;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserService _userService;

        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_userService.UserExists(model.UserName))
                {
                    ModelState.AddModelError("UserName", "User already exists.");
                    return View(model);
                }

                var newUser = new User
                {
                    UserName = model.UserName,
                    Password = model.Password,
                    Email = model.Email,
                    RegistrationDate = model.RegistrationDate
                };

                bool registrationSuccessful = _userService.RegisterUser(newUser);

                if (registrationSuccessful)
                {
                    TempData["SuccessMessage"] = "Registration successful. You can now log in.";
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ModelState.AddModelError("", "Registration failed. Please try again later.");
                }
            }

            return View(model);
        }
    }
}
