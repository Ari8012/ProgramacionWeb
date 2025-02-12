using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class CustomerService : ICustomerService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;
        public CustomerService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        CustomerDTO Convertir(Customer customer)
        {
            return new CustomerDTO
            {
                CustomerId = customer.CustomerId,
                CompanyName = customer.CompanyName

            };
        }

        Customer Convertir(CustomerDTO customer)
        {
            return new Customer
            {
                CustomerId = customer.CustomerId,
                CompanyName = customer.CompanyName

            };

        }
        public void AddCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO Get(int id)
        {
            var customer = _unidadDeTrabajo.CustomerDAL.Get(id);
            return Convertir(customer);
        }

        public List<CustomerDTO> GetAll()
        {
             var customers = _unidadDeTrabajo.CustomerDAL.GetAll();
            List<CustomerDTO> customersDTO = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                customersDTO.Add(Convertir(customer));
            }
            return customersDTO;
        }

        public void UpdateCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

    }
}