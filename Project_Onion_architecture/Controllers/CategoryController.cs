using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Onion_architecture.Models;
using Project_Onion_architecture.Service;

namespace Project_Onion_architecture.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _obj;
        public CategoryController(ICategoryService obj)
        {
            this._obj = obj;
        }
        public IActionResult Index()
        {
            var obj= _obj.GetAll();
            return View(obj);
        }
        [Authorize]
        public IActionResult Create()
        {
        return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj) 
        {
         _obj.Add(obj);
        return RedirectToAction("Index");
        
        }
        public IActionResult Details(int id) 
        {
            var obj = _obj.GetById(id);
            return View(obj);

        }
        public IActionResult Delete(int id)
        {
            var obj=_obj.GetById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(Category obj)
        {
            _obj.Delete(obj);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var obj = _obj.GetById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            _obj.Update(obj);
            return RedirectToAction("Index");
        }
    }
}
