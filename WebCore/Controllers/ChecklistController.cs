using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Controllers
{
    public class ChecklistController : Controller
    {

        private ApplicationContext context;

        public ChecklistController(ApplicationContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {

            /*
            var checklist = context.CheckLists.Join(
                    context.Checks,
                    checkLists => checkLists.ChecklistId,
                    check => check.ChecklistId,
                    (checkLists, check) => new Tuple<string,string,int>
                    (
                        check.text, 
                        checkLists.name,
                        checkLists.ChecklistId
                    )
                ).ToList(); */

            var checklist = context.CheckLists
                .Take(5)
                .Select(cl => new Tuple<ICollection<Check>,string,int>(cl.Checks,cl.name,cl.ChecklistId))
                .ToList();

            return View(checklist);
        }
    }
}
