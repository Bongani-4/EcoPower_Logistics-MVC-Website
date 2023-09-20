using EcoPower_Logistics.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace EcoPower_Logistics.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        // GET: Product
        public IActionResult Index()
        {
            var results = _productRepository.GetAllProducts();
            return View(results);
        }

        // GET: product/Details/5
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Product /Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Product /Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProductId,ProductName,ProductDescription,UnitsInStock")] Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.addProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product /Edit/5
        public IActionResult Edit(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }


        // POST: Product /Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ProductId,ProductName,ProductDescription,UnitsInStock")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _productRepository.updateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        // GET: Product /Delete/5
        public IActionResult Delete(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product /Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            _productRepository.RemoveProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}




