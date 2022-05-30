using Microsoft.AspNetCore.Mvc;
using ML.Recommend.Data;
using ML.Recommend.Predict;
using System.Text.Json;

namespace ML.RecommendWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CustomerController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string customerFile= Path.Combine(path,"customers.json");
            string jsonString = System.IO.File.ReadAllText(customerFile);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
            return View(customers);
        }
        public IActionResult Recommends(int id)
        {
            RecommendEngine engine = new RecommendEngine();
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "Models");
            string modelPath= Path.Combine(path, "ML.Recommend-1.zip");
            engine.LoadModel(modelPath);
            
            path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string customerFile = Path.Combine(path, "customers.json");
            string jsonString = System.IO.File.ReadAllText(customerFile);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
            Customer customer = customers.FirstOrDefault(c => c.Id == id);

            path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string productFile = Path.Combine(path, "products.json");
            jsonString = System.IO.File.ReadAllText(productFile);
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString)!;
            
            float es = 3.5f;
            List<Product> rProducts = engine.Predict(customer, products,es);
            ViewData["customer"] = customer;
            return View(rProducts);
        }
    }
}
