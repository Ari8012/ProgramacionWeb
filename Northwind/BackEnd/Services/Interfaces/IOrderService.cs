using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrdersDTO> GetOrders();
        OrdersDTO Add(OrdersDTO orders);
        OrdersDTO Update(OrdersDTO orders);
        void Delete(int id);
        OrdersDTO GetById(int id);
    }
}
