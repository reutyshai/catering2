
using catering.Core.Entitys;
using catering.Core.Services;
using catering.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catering.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        static int my_id = 1;
        private readonly IOrderService _orders;
        public OrdersController(IOrderService context)
        {
            _orders = context;
        }
        // GET: api/<Orders>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orders.GetAll();
        }

        // GET api/<Orders>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = _orders.GetAll().Find(o => o.Id == id);
            if (order is null)
            {
                return NotFound();
            }
            return Ok(order);
        }
        [HttpGet("customer/{custId}")]
        public ActionResult GetByCust(int id)
        {
            var CustOrders = _orders.GetAll().Where(o => o.CustomerId == id);
            if (CustOrders is null)
            {
                return NotFound();
            }
            return Ok(CustOrders);

        }
        // POST api/<Orders>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _orders.GetAll().Add(new Order(my_id++, order.CustomerId, order.quantity, order.IsSending));
        }

        // PUT api/<Orders>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order order)
        {
            var ord = _orders.GetAll().Find(o => o.Id == id);
            if (ord is null)
            {
                return NotFound();
            }
            ord.quantity = order.quantity;
            ord.IsSending = order.IsSending;
            ord.CustomerId = order.CustomerId;
            return Ok();

        }
        [HttpPut("{id}/isSending")]
        public ActionResult PutSending(int id, [FromBody] Order order)
        {
            var ord = _orders.GetAll().Find(o => o.Id == id);
            if (ord is null)
            {
                return NotFound();
            }
            ord.IsSending = order.IsSending;
            return Ok();
        }
        // DELETE api/<Orders>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = _orders.GetAll().Find(o => o.Id == id);
            if (order is null)
            {
                return NotFound();
            }

            _orders.GetAll().Remove(order);
            return Ok();
        }
    }
}
