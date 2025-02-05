using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        IShipperService _shipperService;

        ILogger<ShipperController> _logger;

        public ShipperController(IShipperService shipperService, ILogger<ShipperController> logger)
        {
            _shipperService = shipperService;
            _logger = logger;
        }

        // GET: api/<ShipperController>
        [HttpGet]
        public IEnumerable<ShipperDTO> Get()
        {
            _logger.LogDebug("Obtener todos los transportistas");
            return _shipperService.GetShippers();
        }

        // GET api/<ShipperController>/5
        [HttpGet("{id}")]
        public ShipperDTO Get(int id)
        {
            return _shipperService.GetShipperById(id);
        }

        // POST api/<ShipperController>
        [HttpPost]
        public void Post([FromBody] ShipperDTO shipper)
        {
            _shipperService.AddShipper(shipper);
        }

        // PUT api/<ShipperController>/5
        [HttpPut]
        public void Put([FromBody] ShipperDTO shipper)
        {
            try
            {
                _shipperService.UpdateShipper(shipper);
            }
            catch (Exception e) 
            { 
                _logger.LogError(e.Message);

            }
            
        }

        // DELETE api/<ShipperController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _shipperService.DeleteShipper(id);
        }
    }
}
