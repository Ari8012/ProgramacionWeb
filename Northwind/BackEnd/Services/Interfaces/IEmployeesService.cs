using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IEmployeesService
    {
        List<EmployeesDTO> GetEmployees();
        EmployeesDTO Add(EmployeesDTO employee);
        EmployeesDTO Update(EmployeesDTO employee);
        void Delete(int id);
        EmployeesDTO GetById(int id);
    }
}
