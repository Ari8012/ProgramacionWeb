using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class ShipperDAL : DALGenericoImple<Shipper>,  IShipperDAL
    {
        private NorthWndContext _context;

        public ShipperDAL(NorthWndContext context): base(context) 
        {
            _context = context;
        }

       
    }
}
