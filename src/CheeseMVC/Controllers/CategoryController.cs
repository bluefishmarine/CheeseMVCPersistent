using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View(context.Categories.ToList());
        }


        public IActionResult Add()
        {

            return View(new AddCategoryViewModel());
        }
            
        // post
        [HttpPost]
        public IActionResult Add(AddCategoryViewModel newCategoryContainer)
        {
            Console.WriteLine(newCategoryContainer.Name);
            if (!ModelState.IsValid) return View("Add");

            context.Categories.Add(new CheeseCategory
            {
                Name = newCategoryContainer.Name
            });
            context.SaveChanges();

            return Redirect("/Category");
        }
    }
}