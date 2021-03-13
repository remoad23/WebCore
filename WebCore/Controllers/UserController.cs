using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace WebCore.Controllers
{
    public class UserController : Controller
    {

        private ApplicationContext context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(ApplicationContext _context,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            context = _context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var users = this.context.Users.FromSqlRaw("SELECT * FROM USER").ToList();
            ViewData["user"] = "test";// users.First().username;

            return View();
        }

    }
}
