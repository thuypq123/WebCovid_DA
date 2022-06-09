using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class ProductController : Controller
    {

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
            var sanpham = _context.Sanphams.First(x => x.Masp == id);
            return View(sanpham);
        }
<<<<<<< HEAD
=======
=======
        covid19Context db = new covid19Context();
        public IActionResult Index()
        {
            var sanpham = db.Sanphams.ToList();
            return View(sanpham);
        }
>>>>>>> 8abde6598f3ac008472d2952bb01709e89451136
>>>>>>> d0d1d818661b459bf7760d296e86cd51e36d9e1a
        public IActionResult Pagecarts()
        {
            return View();
        }
    }
}
