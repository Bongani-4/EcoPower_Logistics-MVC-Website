
using coPower_Logistics;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(SuperStoreContext context) : base(context)
        {
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetails()
        {
            return await _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .ToListAsync();
        }

        public async Task<OrderDetail?> GetOrderDetailById(int id)
        {
            return await _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .FirstOrDefaultAsync(od => od.OrderDetailsId == id);
        }




        public void AddOrderDetail(OrderDetail orderDetail)
        {
            Add(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            Update(orderDetail);
        }

        public void RemoveOrderDetail(int id)
        {
            var orderDetail = GetById(id);
            if (orderDetail != null)
            {
                Remove(orderDetail);
            }
        }
    }
}
