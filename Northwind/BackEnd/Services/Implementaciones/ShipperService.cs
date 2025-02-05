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

        Shipper Convertir (ShipperDTO shipper)
        {
            return new Shipper
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName
            };
        }

        ShipperDTO Convertir(Shipper shipper)
        {
            return new ShipperDTO
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName
            };
        }
        public void AddShipper(ShipperDTO shipper)
        {
            var shipperEntity = Convertir (shipper);

            _unidadDeTrabajo.ShipperDAL.Add(shipperEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteShipper(int id)
        {
            var shipper = new Shipper { ShipperId = id};
            _unidadDeTrabajo.ShipperDAL.Remove(shipper);
            _unidadDeTrabajo.Complete();
        }

        public List<ShipperDTO> GetShippers()
        {
            var result = _unidadDeTrabajo.ShipperDAL.GetAllShippers();

            List<ShipperDTO> shippers = new List<ShipperDTO>();
            foreach (var item in result) 
            {
                shippers.Add(Convertir (item));

            }
            return shippers;
        }

        public void UpdateShipper(ShipperDTO shipper)
        {
            var shipperEntity = Convertir(shipper);

            _unidadDeTrabajo.ShipperDAL.Update(shipperEntity);
            _unidadDeTrabajo.Complete();
        }

        public ShipperDTO GetShipperById(int id)
        {
            var result = _unidadDeTrabajo.ShipperDAL.Get(id);
            return Convertir(result);
        }
    }
}
