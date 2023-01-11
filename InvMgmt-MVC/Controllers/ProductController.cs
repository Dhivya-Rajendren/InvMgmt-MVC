using InvMgmt_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvMgmt_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly InvMgmtDbContext dbContext;

        public ProductController(InvMgmtDbContext  dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {

            List<Product> products = dbContext.Products.ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    
    public IActionResult Details(int productId)
        {
            Product product = dbContext.Products.Find(productId);
            return View(product);
        }

        public IActionResult Delete(int productId)
        {
            Product product = dbContext.Products.Find(productId);
            return View(product);
        }


    }
}
