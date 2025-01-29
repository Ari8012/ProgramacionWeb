using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace DAL.Interfaces
{
    public interface IShipperDAL
    {
        bool AddShipper(Shipper shipper);
        bool UpdateShipper(Shipper shipper);
        bool DeleteShipper(int id);
        List<Shipper> GetShippers();
    }
}
