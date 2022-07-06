using ForOleksiyAspNet5.Data;
using ForOleksiyAspNet5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOleksiyAspNet5.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;

        public HomeController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index([FromQuery] DateTime created_start, [FromQuery] DateTime created_end)
        {
            if (created_start == default(DateTime) && created_end == default(DateTime))
            {
                ViewData["Start_date"] = DateTime.Now.AddMonths(-1);
                ViewData["End_date"] = DateTime.Now;
            }
            else
            {
                ViewData["Start_date"] = created_start;
                ViewData["End_date"] = created_end;
            }


            var model = _context.Moveses.Where(x => x.Created >= created_start &&
             x.Created <= created_end).ToArray();
            return View(model);
        }



        [HttpPost]
        public IActionResult Post([FromBody] DateTime created_start, [FromBody] DateTime created_end)
        {

            var model = _context.Moveses.Where(x => x.Created >= created_start &&
             x.Created <= created_end).ToArray();

            return RedirectToAction(nameof(Index), new { created_start = created_start, created_end = created_end });
        }
    }
}
