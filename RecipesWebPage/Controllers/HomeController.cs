using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipesWebPage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebPage.Controllers
{
    public class HomeController : Controller
    {
        private RecipeDbContext _context { get; set; }
        public HomeController(RecipeDbContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var blah = _context.Recipes.ToList();

            return View(blah);
        }
    }
}
