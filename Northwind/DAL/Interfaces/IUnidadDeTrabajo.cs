using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        IShipperDAL ShipperDAL { get; }
        ICustomerDAL CustomerDAL { get; }
        IEmployeesDAL EmployeesDAL { get; }

        bool Complete();
    }
}
