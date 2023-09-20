using EcoPower_Logistics.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System.Threading.Tasks;

namespace EcoPower_Logistics.Controllers
{
    [Authorize]
    public class OrderDetailsController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICustomerRepository _customerRepository;

        public OrderDetailsController(IOrderRepository orderRepository, IProductRepository productRepository, ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _customerRepository = customerRepository;
        }

        // GET: OrderDetails
        // GET: OrderDetails
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepository.GetAllOrders();
            return View(orders);
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _orderRepository.GetOrderDetailById(id.Value);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public async Task<IActionResult> Create()
        {
            var orders = await _orderRepository.GetAllOrders(); // Await the async method
            ViewData["OrderId"] = new SelectList(orders, "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productRepository.GetAllProducts(), "ProductId", "ProductId");
            return View();
        }


        // POST: OrderDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                await _orderRepository.AddOrderDetail(orderDetail);
                return RedirectToAction(nameof(Index));
            }


            var orders = await _orderRepository.GetAllOrders();
            var products = _productRepository.GetAllProducts();

            ViewData["OrderId"] = new SelectList(orders, "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(products, "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }


        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _orderRepository.GetOrderDetailById(id.Value);

            if (orderDetail == null)
            {
                return NotFound();
            }

            ViewData["OrderId"] = new SelectList(await _orderRepository.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productRepository.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _orderRepository.UpdateOrderDetail(orderDetail);
                }
                catch
                {
                    if (!(await OrderDetailExists(orderDetail.OrderDetailsId)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["OrderId"] = new SelectList(await _orderRepository.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productRepository.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _orderRepository.GetOrderDetailById(id.Value);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!(await OrderDetailExists(id)))
            {
                return NotFound();
            }

            await _orderRepository.RemoveOrderDetail(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> OrderDetailExists(int id)
        {
            var orderDetail = await _orderRepository.GetOrderDetailById(id);
            return orderDetail != null;
        }
    }
}


