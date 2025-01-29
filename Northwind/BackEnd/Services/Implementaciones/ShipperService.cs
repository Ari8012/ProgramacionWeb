using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class ShipperService : IShipperService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public ShipperService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }
        public void AddShipper(ShipperDTO shipper)
        {
            var shipperEntity = new Shipper()
            {
                CompanyName = shipper.CompanyName
            };

            _unidadDeTrabajo.ShipperDAL.Add(shipperEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteShipper(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetShippers()
        {
            throw new NotImplementedException();
        }

        public void UpdateShipper(Shipper shipper)
        {
            _unidadDeTrabajo.ShipperDAL.Update(shipper);
            _unidadDeTrabajo.Complete();
        }
    }
}
