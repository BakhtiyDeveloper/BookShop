using BookShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        private readonly IWebHostEnvironment environment;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p => p.BookId).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
