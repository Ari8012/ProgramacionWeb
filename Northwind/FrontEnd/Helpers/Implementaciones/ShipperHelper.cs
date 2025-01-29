using FrontEnd.ApiModels;
using FrontEnd.Controllers;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementaciones
{
    public class ShipperHelper : IShipperHelper
    {
        IServiceRepository _ServiceRepository;

        ShipperViewModel Convertir(ShipperAPI shipper)
        {
            ShipperViewModel shipperViewModel = new ShipperViewModel
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName
            };
            return shipperViewModel;
        }
        public ShipperHelper(IServiceRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }
        public ShipperViewModel Add(ShipperViewModel shipper)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ShipperViewModel GetShipper(int? id)
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Shipper/" + id.ToString());
            ShipperAPI shipper = new ShipperAPI();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                shipper = JsonConvert.DeserializeObject<ShipperAPI>(content);
            }

            ShipperViewModel resultado = Convertir(shipper);


            return resultado;
        }

        public List<ShipperViewModel> GetShippers()
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Shipper");
            List<ShipperAPI> shippers = new List<ShipperAPI>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                shippers = JsonConvert.DeserializeObject<List<ShipperAPI>>(content);
            }
            List<ShipperViewModel> lista = new List<ShipperViewModel>();
            foreach (var shipper in shippers)
            {
                lista.Add(Convertir(shipper));
            }
            return lista;
        }

        public ShipperViewModel Update(ShipperViewModel shipper)
        {
            throw new NotImplementedException();
        }
    }
}
