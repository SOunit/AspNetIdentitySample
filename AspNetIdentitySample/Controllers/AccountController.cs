using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using AspNetIdentitySample.Identity;
using AspNetIdentitySample.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace AspNetIdentitySample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        public ActionResult Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                // register
                var appDbContext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbContext);
                var userManager = new ApplicationUserManager(userStore);
                var passwordHash = Crypto.HashPassword(rvm.Password);
                var user = new ApplicationUser()
                {
                    Email = rvm.Email,
                    UserName = rvm.Username,
                    PasswordHash = passwordHash,
                    City = rvm.City,
                    Country = rvm.Country,
                    Birthday = rvm.DateOfBirth,
                    Address = rvm.Address,
                    PhoneNumber = rvm.Mobile
                };
                IdentityResult result = userManager.Create(user);
                if (result.Succeeded)
                {
                    // role
                    userManager.AddToRole(user.Id, "Customer");

                    // login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("My Error", "Invalid Data");
                return View();
            }
        }
    }
}