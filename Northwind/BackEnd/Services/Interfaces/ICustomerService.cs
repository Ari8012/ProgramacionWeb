using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(CustomerDTO customer);
        void UpdateCustomer(CustomerDTO customer);
        void DeleteCustomer(int id);
        List<CustomerDTO> GetAll();
        CustomerDTO Get(int id);
    }
}
