using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class CustomerDAL : DALGenericoImple<Customer>, ICustomerDAL
    {
        NorthWndContext _context;

        public CustomerDAL(NorthWndContext context): base(context) 
        {
            _context = context;
        }
    }
}
