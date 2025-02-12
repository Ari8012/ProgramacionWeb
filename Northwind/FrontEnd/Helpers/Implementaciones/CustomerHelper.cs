using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementaciones
{
    public class CustomerHelper : ICustomerHelper
    {
        IServiceRepository _ServiceRepository;

        public CustomerHelper(IServiceRepository serviceRepository)
        {
            this._ServiceRepository = serviceRepository;
        }


        CustomerViewModel Convertir(CustomerAPI customer)
        {
            return new CustomerViewModel
            {
                CustomerId = customer.CustomerId,
                CompanyName = customer.CompanyName
               
            };
        }
        public List<CustomerViewModel> GetAll()
        {
            List<CustomerAPI> customer = new List<CustomerAPI>();

            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/customer");

            if (responseMessage != null)
            {

                var content = responseMessage.Content.ReadAsStringAsync().Result;
                customer = JsonConvert.DeserializeObject<List<CustomerAPI>>(content);

            }
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();

            foreach (var item in customer)
            {
                customerViewModels.Add(Convertir(item));
            }
            return customerViewModels;

        }

    }
    
}
