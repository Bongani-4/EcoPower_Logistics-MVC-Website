using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using coPower_Logistics;
using System.Linq;
using Models;
using System.Collections.Generic;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        public async Task AddOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }

          
            var existingOrder = await _context.Orders.FindAsync(orderDetail.OrderId);
            if (existingOrder == null)
            {
                throw new ArgumentException("The specified order does not exist.", nameof(orderDetail));
            }

            // Add the order detail to the order's collection of order details.
            existingOrder.OrderDetails.Add(orderDetail);

            // Save changes to the database.
            await _context.SaveChangesAsync();
        }

        public async Task<OrderDetail?> GetOrderDetailById(int id)
        {
            var orderDetail = await _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .FirstOrDefaultAsync(od => od.OrderDetailsId == id);

            return orderDetail; 
        }


        public async Task<Order?> GetOrderById(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.OrderId == id);
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetails()
        {
            return await _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .ToListAsync();
        }
        public async Task UpdateOrderDetail(OrderDetail orderDetail)
{
    var existingOrderDetail = await _context.OrderDetails.FindAsync(orderDetail.OrderDetailsId);

    if (existingOrderDetail != null)
    {
        
        existingOrderDetail.OrderId = orderDetail.OrderId;
        existingOrderDetail.ProductId = orderDetail.ProductId;
        existingOrderDetail.Quantity = orderDetail.Quantity;
        existingOrderDetail.Discount = orderDetail.Discount;

        // Save the changes to the database.
        await _context.SaveChangesAsync();
    }
}
        public async Task RemoveOrderDetail(int id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                await _context.SaveChangesAsync();
            }
        }



        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await GetAll().ToListAsync();
        }
        public void AddOrder(Order entity)
        {
            Add(entity);
        }

        public void RemoveOrder(Order entity)
        {
            Remove(entity);
        }

        public void UpdateOrder(Order entity)
        {
            Update(entity);
        }
        private IQueryable<Order> GetAll()
        {
            return _context.Orders.AsQueryable();
        }

    }
}

