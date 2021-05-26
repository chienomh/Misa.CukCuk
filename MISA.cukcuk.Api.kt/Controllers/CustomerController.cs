using Microsoft.AspNetCore.Mvc;
using MISA.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.cukcuk.Api.kt.Controllers
{
    [Route("api/v1.customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            var customers = customerRepository.GetAll();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{customerId}")]
        public IActionResult Get(Guid customerId)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            var customers = customerRepository.GetById(customerId);
            return Ok(customers);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
