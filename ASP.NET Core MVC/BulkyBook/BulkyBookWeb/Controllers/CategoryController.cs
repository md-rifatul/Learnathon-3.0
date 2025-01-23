using BulkyBookWeb.Models;
using BulkyBookWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _categoryService.GetAllCategories();
            return View(categoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _categoryService.AddCategory(obj);
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _categoryService.GetCategoryById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _categoryService.UpdateCategory(obj);
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _categoryService.GetCategoryById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _categoryService.DeleteCategory(id.Value);
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
