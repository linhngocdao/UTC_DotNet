using DaoNgocLinh.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DaoNgocLinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("ByCategory/{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var products = _context.Products
                .Where(p => p.Available && p.CategoryId == categoryId)
                .Select(p => new {
                    p.Id,
                    p.Name,
                    p.UnitPrice,
                    p.Image,
                    p.Description
                })
                .ToList();
            return Ok(products);
        }
    }
}
