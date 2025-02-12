using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementaciones
{
    public class OrderHelper : IOrderHelper
    {
        IServiceRepository _repository;

        public OrderHelper(IServiceRepository serviceRepository)
        {
            this._repository = serviceRepository;
        }

        OrderViewModel Convertir(OrdersAPI order)
        {
            return new OrderViewModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                CustomerId = order.CustomerId,
                EmployeeId = order.EmployeeId,
                ShipperId = order.ShipperId
            };
        }

        OrdersAPI Convertir(OrderViewModel order)
        {
            return new OrdersAPI
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                CustomerId = order.CustomerId,
                EmployeeId = order.EmployeeId,
                ShipperId = order.ShipperId
               
            };
        }

        public OrderViewModel AddOrder(OrderViewModel OrderViewModel)
        {
            HttpResponseMessage responseMessage = _repository.PostResponse("api/order", Convertir(OrderViewModel));
            if (responseMessage != null)
            {
                var content = responseMessage.Content;
            }


            return OrderViewModel;

        }

        public void DeleteOrder(int id)
        {
            HttpResponseMessage responseMessage = _repository.DeleteResponse("api/order" + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content;
            }

           

        }

        public OrderViewModel EditOrder(OrderViewModel OrderViewModel)
        {
            HttpResponseMessage responseMessage = _repository.PutResponse("api/order", Convertir(OrderViewModel));
            if (responseMessage != null)
            {
                var content = responseMessage.Content;
            }


            return OrderViewModel;
        }

        public List<OrderViewModel> GetAll()
        {
            List<OrdersAPI> orders = new List<OrdersAPI>();
            HttpResponseMessage responseMessage = _repository.GetResponse("api/order");


            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                orders = JsonConvert.DeserializeObject<List<OrdersAPI>>(content);


            }

            List<OrderViewModel> list = new List<OrderViewModel>();


            foreach (var item in orders)
            {
                list.Add(Convertir(item));
            }
            return list;


        }

        public OrderViewModel GetById(int id)
        {
            OrdersAPI OrderAPI = new OrdersAPI();
            HttpResponseMessage responseMessage = _repository.GetResponse("api/order/" + id.ToString());


            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                OrderAPI = JsonConvert.DeserializeObject<OrdersAPI>(content);


            }

            return Convertir(OrderAPI);
        }

    }
    
}
