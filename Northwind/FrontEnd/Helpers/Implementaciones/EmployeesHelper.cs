using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementaciones
{
    public class EmployeesHelper : IEmployeesHelper
    {
        IServiceRepository _ServiceRepository;

        public EmployeesHelper(IServiceRepository serviceRepository)
        {
            this._ServiceRepository = serviceRepository;
        }


        EmployeesViewModel Convertir(EmployeesAPI employees)
        {
            return new EmployeesViewModel
            {
                EmployeeId = employees.EmployeeId,
                LastName = employees.LastName,
                FirstName = employees.FirstName

            };
        }
        public List<EmployeesViewModel> GetAll()
        {
            List<EmployeesAPI> employees = new List<EmployeesAPI>();

            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/employees");

            if (responseMessage != null)
            {

                var content = responseMessage.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeesAPI>>(content);

            }
            List<EmployeesViewModel> employeesViewModels = new List<EmployeesViewModel>();

            foreach (var item in employees)
            {
                employeesViewModels.Add(Convertir(item));
            }
            return employeesViewModels;

        }
    }
}
