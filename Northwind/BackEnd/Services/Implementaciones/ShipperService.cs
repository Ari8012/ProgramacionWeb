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
        public void AddShipper(Shipper shipper)
        {
            _unidadDeTrabajo.ShipperDAL.Add(shipper);
            _unidadDeTrabajo.Complete();
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
            _unidadDeTrabajo.ShipperDAL.Update(shipper);
            _unidadDeTrabajo.Complete();
        }
    }
}
