using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class ShipperService : IShipperService
    {
        private IShipperDAL _shipperDAL;
        public ShipperService(IShipperDAL shipperDAL)
        {
            _shipperDAL = shipperDAL;
        }
        public void AddShipper(Shipper shipper)
        {
            _shipperDAL.AddShipper(shipper);
        }

        public void DeleteShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetShippers()
        {
            throw new NotImplementedException();
        }

        public void UpdateShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
