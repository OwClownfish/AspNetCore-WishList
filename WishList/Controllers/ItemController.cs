using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using System.Linq;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Items.ToList();
            return View("Index", model);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
    }
}
