

using catering.Core.Entitys;
using catering.Core.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catering.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        static int my_id = 1;
        private readonly ICustomerService _customers;
        public CustomersController(ICustomerService context)
        {
            _customers = context;
        }
        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers.GetAll();
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customer = _customers.GetAll().Find(c => c.id == id);
            if(customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] Customer cust)
        {
            _customers.GetAll().Add(new Customer { id = my_id++, phone = cust.phone, adress = cust.adress, name = cust.name });
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer cust)
        {
            var customer= _customers.GetAll().Find(c => c.id == id);
            if(customer == null)
            {
                return NotFound();
            }
            customer.name=cust.name;
            customer.phone=cust.phone;
            customer.adress=cust.adress;
            _customers.SaveChanges();
            return Ok(customer); 
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var customer = _customers.GetAll().Find(c => c.id == id);
            if(customer == null)
            {
                return NotFound();
            }
            _customers.GetAll().Remove(customer);
            return Ok();
            
        }
    }
}
