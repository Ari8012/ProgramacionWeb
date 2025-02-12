using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult Get()
        {
            var result = _orderService.GetOrders();

            return Ok(result);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result = _orderService.GetById(id);

            return Ok(result);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] OrdersDTO ordersDTO)
        {
            _orderService.Add(ordersDTO);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrdersDTO orders)
        {
            _orderService.Update(orders);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}
