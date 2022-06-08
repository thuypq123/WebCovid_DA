using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class ProductController : Controller
    {
        covid19Context db = new covid19Context();
        public IActionResult Index()
        {
            var sanpham = db.Sanphams.ToList();
            return View(sanpham);
        }
        public IActionResult Pagecarts()
        {
            return View();
        }
    }
}
