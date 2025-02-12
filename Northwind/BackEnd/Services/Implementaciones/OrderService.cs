using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class OrderService : IOrderService
    {
        IUnidadDeTrabajo _Unidad;
        public OrderService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _Unidad = unidadDeTrabajo;
        }

        OrdersDTO Convertir(Order order)
        {
            return new OrdersDTO
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                EmployeeId = order.EmployeeId,
                ShipperId = order.ShipVia,
                OrderDare = (DateTime)order.OrderDate

            };
        }

        Order Convertir(OrdersDTO orders)
        {
            return new Order
            {
                OrderId = orders.OrderId,
                CustomerId = orders.CustomerId,
                EmployeeId = orders.EmployeeId
            };

        }
        public OrdersDTO Add(OrdersDTO orders)
        {
            try
            {
                _Unidad.OrderDAL.Add(Convertir(orders));

                _Unidad.Complete();
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {

            Order order = new Order{OrderId = id };
            _Unidad.OrderDAL.Remove(order);
            _Unidad.Complete();
            throw new NotImplementedException();
        }

        public OrdersDTO GetById(int id)
        {
            var order = _Unidad.OrderDAL.Get(id);
            return Convertir(order);
        }

        public List<OrdersDTO> GetOrders()
        {
            var orders = _Unidad.OrderDAL.GetAll();
            List<OrdersDTO> orderList = new List<OrdersDTO>();
            foreach (var order in orders)
            {

                orderList.Add(Convertir(order));
            }
            return orderList;
        }

        public OrdersDTO Update(OrdersDTO order)
        {
            try
            {
                _Unidad.OrderDAL.Update(Convertir(order));

                _Unidad.Complete();
                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
