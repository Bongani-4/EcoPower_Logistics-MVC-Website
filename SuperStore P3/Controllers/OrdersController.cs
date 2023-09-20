using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: Orders
       
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepository.GetAllOrders();
            return View(orders);
        }


        // GET: Orders/Details/5
        public IActionResult Details(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {

            return View();
        }


        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("OrderId,OrderDate,CustomerId,DeliveryAddress")] Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.AddOrder(order);
                return RedirectToAction(nameof(Index));
            }


            ViewData["OrderId"] = new SelectList(new List<Order>(), "OrderId", "CustomerId");

            return View(order);
        
        }



        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            // Create an empty SelectList
            ViewData["OrderId"] = new SelectList(new List<Order>(), "OrderId", "CustomerId");

            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,CustomerId,DeliveryAddress")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _orderRepository.UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }

            // Create an empty SelectList
            ViewData["OrderId"] = new SelectList(new List<Order>(), "OrderId", "CustomerId");

            return View(order);
        }


        // GET: Orders/Delete/5
        public IActionResult Delete(int id)
        {
            var order = _orderRepository.GetOrderById(id); // Use the repository method
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var _Order = await _orderRepository.GetOrderById(id);
            _orderRepository.RemoveOrder(_Order);
            return RedirectToAction(nameof(Index));
        }
    }
}





