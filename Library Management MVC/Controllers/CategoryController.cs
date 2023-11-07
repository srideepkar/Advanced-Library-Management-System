using Advance_Library_Management_Application.Data;
using Advance_Library_Management_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Advance_Library_Management_Application.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _db.Categories;
            return View(categoryList);
        }

        //GET
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Category obj)
        {
            if (obj != null)
            {
                if (ModelState.IsValid)
                {
                    try { 
                        _db.Categories.Add(obj);
                        _db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
            return View(obj);
        }

        [Authorize(Roles = "Admin,Manager")]
        //GET
        [HttpGet]
        public IActionResult Edit(int? id) {
            if (ModelState.IsValid)
            {
                var book_obj = _db.Categories.Find(id);
                if (book_obj == null) 
                {
                    return NotFound();
                }
                ViewBag.book = book_obj;
            }
            return View();
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category? obj)
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    _db.Categories.Update(obj);
                    _db.SaveChanges();
                }
                else
                {
                    return BadRequest();
                }
            }
            return RedirectToAction("Index");
        }

        //GET
        [Authorize(Roles = "Admin,Manager")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (ModelState.IsValid)
            {
                if(id == null)
                {
                    return NotFound();
                }
                else
                {
                    var book_id = _db.Categories.Find(id);
                    if (book_id == null)
                    {
                        return NotFound();
                    }
                    ViewBag.BookName = book_id.BookName;
                }
            }
            return View();
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    var obj = _db.Categories.Find(id);
                    if(obj == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        _db.Categories.Remove(obj);
                        _db.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Member,Admin,Manager")]
        [HttpGet]
        public IActionResult BookDetail(int id)
        {
            if (ModelState.IsValid)
            {
                var obj = _db.Categories.Find(id);
                if(obj == null)
                {
                    return BadRequest();
                }
                ViewBag.book_detail = obj;
            }
            return View();
        }
    }
}
