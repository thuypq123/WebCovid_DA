using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 7595ce5a1435497a83a0e5ac294cc0a52952bec3
using System.Linq;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class ProductController : Controller
    {
<<<<<<< HEAD
        private readonly covid19Context _context;

        public ProductController()
        {
            _context = new covid19Context();
        }

        public IActionResult Index()
        {
            var sanpham = _context.Sanphams.ToList();
            return View(sanpham);
        }
        public IActionResult Details(int id)
        {
            //var sanpham = _context.Sanphams.Include(x => x.MadmNavigation).FirstOrDefault(x => x.Masp == id);
            //if (sanpham == null)
            //{
            //    return RedirectToAction("Index");
            //}
            return View();
=======
        covid19Context db = new covid19Context();
        public IActionResult Index()
        {
            var sanpham = db.Sanphams.ToList();
            return View(sanpham);
>>>>>>> 7595ce5a1435497a83a0e5ac294cc0a52952bec3
        }
        public IActionResult Pagecarts()
        {
            return View();
        }
    }
}
