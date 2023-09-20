using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<IEnumerable<OrderDetail>> GetAllOrderDetails();
        Task<OrderDetail> GetOrderDetailById(int id);
        Task AddOrderDetail(OrderDetail orderDetail);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void RemoveOrder(Order order);
        Task UpdateOrderDetail(OrderDetail orderDetail);
        Task RemoveOrderDetail(int id);


    }
}



