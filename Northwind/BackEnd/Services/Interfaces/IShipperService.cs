using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IShipperService
    {
        void AddShipper(Shipper shipper);
        void UpdateShipper(Shipper shipper);
        void DeleteShipper(Shipper shipper);
        List<Shipper> GetShippers();

    }
}
