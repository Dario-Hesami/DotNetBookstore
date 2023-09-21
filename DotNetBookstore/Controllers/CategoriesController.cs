using DotNetBookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookstore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()

        {
            // use the Category model to generate 10 categories in memory for display in the view
            var categories = new List<Category>();
            for (int i = 0; i< 11; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }
            return View(categories);
        }
        public IActionResult Browse(string category)

        {
            if (category == null)
            {
                return RedirectToAction("index");
            }

            ViewBag.category = category;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
