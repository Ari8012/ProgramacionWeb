//using BackEndAM.Controllers;
using BackEndAM.DTO;
using Entities.Entities;

namespace BackEndAM.Services.Interfaces
{
    public interface IShipperService
    {
        void AddShipper(ShipperDTO shipper);
        void UpdateShipper(ShipperDTO shipper);
        void DeleteShipper(int id);
        List<ShipperDTO> GetShippers();
        ShipperDTO GetShipperById(int id);

    }
}
