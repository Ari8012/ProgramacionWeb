using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            this._employeesService = employeesService;
        }


        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult Get()
        {
            var result = _employeesService.GetEmployees();
            return Ok(result);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result = _employeesService.GetById(id);
            return Ok(result);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] EmployeesDTO employeesDTO)
        {
            _employeesService.Add(employeesDTO);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeesDTO employees)
        {
           _employeesService.Update(employees);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeesService.Delete(id);
        }
    }
}
