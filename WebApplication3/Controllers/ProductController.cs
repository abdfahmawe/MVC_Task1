using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.products.ToList();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = context.products.Find(id);
            return View(product);
        }
        public ViewResult Create()
        {
            return View();  
        }
        public IActionResult Add(Product product)
        {
            context.products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
