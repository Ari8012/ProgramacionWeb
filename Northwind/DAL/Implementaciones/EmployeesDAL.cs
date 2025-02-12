using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class EmployeesDAL : DALGenericoImple<Employee>, IEmployeesDAL
    {
        NorthWndContext _context;

        public EmployeesDAL(NorthWndContext context) : base(context)
        {
            _context = context;
        }
    }
}
