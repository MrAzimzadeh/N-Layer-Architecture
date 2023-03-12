using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ILogger<CategoryController> logger, ICategoryServices categoryServices)
        {
            _logger = logger;
            _categoryServices = categoryServices;
        }

        public IActionResult Index()
        {
            var categories = _categoryServices.GetAllCategories();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category categoy)
        {
            if (!ModelState.IsValid)
            {
                return View(categoy);
            }
            _categoryServices.AddCategory(categoy);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var editCategory = _categoryServices.GetCategoryById(id);
            return View(editCategory);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Name == null)
            {
                return View(category);
            }
            else
            {
                _categoryServices.UpdateCategory(category);
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Delete(int id)
        {
            var deleteCategory = _categoryServices.GetCategoryById(id);
            return View(deleteCategory);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _categoryServices.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }

    }
}