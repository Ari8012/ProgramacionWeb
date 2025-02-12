using FrontEnd.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IEmployeesHelper
    {
        List<EmployeesViewModel> GetAll();
    }
}
