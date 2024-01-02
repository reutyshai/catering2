using catering.Core.Entitys;
using catering.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        static int my_id = 1;
        private readonly IDishesService _dishes;
        public DishesController(IDishesService context)
        {
            _dishes = context;
        }
        // GET: api/<Dishes>
        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            return _dishes.GetAll();
        }

        // GET api/<Dishes>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var dish = _dishes.GetAll().Find(d => d.id == id);
            if (dish is null)
            {
                return NotFound();
            }
            return Ok(dish);
            
        }
        [HttpGet("price/{price}")]
        public ActionResult  GetByPrice(int price)
        {
            var dish = _dishes.GetAll().Where(d => d.price <= price);
            if (dish is null)
            {
                return NotFound();
            }
            return Ok(dish) ;
        }
        // POST api/<Dishes>
        [HttpPost]
        public void Post([FromBody] Dish dish)
        {
            _dishes.GetAll().Add(new Dish(my_id++, dish.price, dish.name,dish.sideDish, dish.isSideDish));
        }

        // PUT api/<Dishes>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Dish dish)
        {

            var di= _dishes.GetAll().Find(d=>d.id == id);
            
            if (di is null)
            {
                return NotFound();
            }
            di.name= dish.name;
            di.price= dish.price;
            di.sideDish= dish.sideDish;
            di.isSideDish= dish.isSideDish;
            return Ok();
        }
       
        // DELETE api/<Dishes>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var dish = _dishes.GetAll().Find(d => d.id == id);
            if (dish is null)
            {
                return NotFound();
            }
            _dishes.GetAll().Remove(dish);
            return Ok();
            
        }
    }
}
