using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class ShipperDAL
    {
        private NorthWndContext _context;

        public ShipperDAL(NorthWndContext context)
        {
            _context = context;
        }

        public bool AddShipper(Shipper shipper)
        {
            try
            {
                _context.Add(shipper);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteShipper(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetShippers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
