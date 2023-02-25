using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Data;
using WebApiTest.Entities;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StateController: ControllerBase
    {
      
            private readonly StoreContext _context;
            public StateController(StoreContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<State>>> GetProducts()
            {
                //synchronous
                // var products=context.Products.ToList();
                // return Ok(products);
                return await _context.States.ToListAsync();
            }
            [HttpGet("{id}")]
            public async Task<ActionResult<List<State>>> GetProducts(int id)
            {
                var states = await _context.States.FindAsync(id);
                return Ok(states);
            }
    }
}
