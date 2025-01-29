using BackEnd.Controllers;
using BackEnd.DTO;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IShipperService
    {
        void AddShipper(ShipperDTO shipper);
        void UpdateShipper(Shipper shipper);
        void DeleteShipper(int id);
        List<Shipper> GetShippers();
    }
}
