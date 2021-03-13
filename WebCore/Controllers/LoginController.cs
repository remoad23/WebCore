using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using WebCore.Models;

namespace WebCore.Controllers
{
    public class LoginController : Controller
    {
        private ApplicationContext context;

        public LoginController(ApplicationContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string password)
        {
     //       var user = context.Users.Single(u => u.email == email && u.password == password);

//            HttpContext.Session.SetString("username", user.username);

  //          Console.WriteLine(user.username);

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
