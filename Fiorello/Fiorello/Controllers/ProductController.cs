using Fiorello.Dal;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _appDbContext;
        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

    }
}
