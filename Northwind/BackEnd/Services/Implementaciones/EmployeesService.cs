using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class EmployeesService : IEmployeesService
    {
        IUnidadDeTrabajo _Unidad;
        public EmployeesService(IUnidadDeTrabajo unidadDeTrabajo) 
        {
            _Unidad = unidadDeTrabajo;
        }

        EmployeesDTO Convertir(Employee employee)
        {
            return new EmployeesDTO
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName

            };
        }

        Employee Convertir(EmployeesDTO employee)
        {
            return new Employee 
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };

        }
        public EmployeesDTO Add(EmployeesDTO employee)
        {
            try
            {
                _Unidad.EmployeesDAL.Add(Convertir(employee));

                _Unidad.Complete();
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {

            Employee employee = new Employee { EmployeeId = id };
            _Unidad.EmployeesDAL.Remove(employee);
            _Unidad.Complete();
            throw new NotImplementedException();
        }

        public EmployeesDTO GetById(int id)
        {
            var employee = _Unidad.EmployeesDAL.Get(id);
            return Convertir(employee);
        }

        public List<EmployeesDTO> GetEmployees()
        {
            var employees = _Unidad.EmployeesDAL.GetAll();
            List<EmployeesDTO> employeesList = new List<EmployeesDTO>();
            foreach (var employee in employees)
            {

                employeesList.Add(Convertir(employee));
            }
            return employeesList;
        }

        public EmployeesDTO Update(EmployeesDTO employee)
        {
            try
            {
                _Unidad.EmployeesDAL.Update(Convertir(employee));

                _Unidad.Complete();
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
