using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class OrdersDAL: DALGenericoImple<Order>, IOrderDAL
    {
        NorthWndContext _context;

        public OrdersDAL(NorthWndContext context) : base(context)
        {
            _context = context;
        }
    }
}
