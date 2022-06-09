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
        public IActionResult Pagecarts()
        {
            return View();
        }
    }
}
