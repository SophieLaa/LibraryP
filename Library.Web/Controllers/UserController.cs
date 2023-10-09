using Library.Service;
using Library.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Login()
        {
            LogInViewModel logInViewModel = new LogInViewModel();
            return View(logInViewModel);
        }

        [HttpPost]
        public ActionResult Login(LogInViewModel model)
        {
            if (_userService.ValidateUser(model.Username, model.Password))
            {
                return Content("Login successful");
            }

            return Content("Invalid username or password");
        }

        public ActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    RegistrationDate = DateTime.Now,
                   
                };
                //_userService.RegisterUser(newUser);

               
                bool registrationSuccessful = _userService.RegisterUser(newUser);

                if (registrationSuccessful)
                {
                    TempData["SuccessMessage"] = "Registration successful. You can now log in.";
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Username already exists.");
                }
            }

            return View(model);
        }

    }
}
