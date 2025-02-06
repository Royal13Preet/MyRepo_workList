using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Product_Managementmvc.MvcView.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult  Authenticate(string username, string password)
        {
           
            if (username == "admin" && password == "password") 
            {
                var claims = new List<Claim>
            {
                
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin") 
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(30)
                };

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

                if (User.Identity.IsAuthenticated)
                {
                    return RedirectToAction("GetAll", "Product");
                }
                //return RedirectToAction("GetAll", "Product");
            }

            ViewBag.Error = "Invalid username or password";
            return View("Index");
            
        }
       

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        
    }


}
