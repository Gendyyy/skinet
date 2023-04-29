

using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Product>>> GetDate()
        {
            // await Task.Delay(TimeSpan.FromSeconds(20));
            var result = await _context.Products.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetData(int id)
        {
            var result = await _context.Products.FindAsync(id);
            return Ok(result);
        }

    }
}