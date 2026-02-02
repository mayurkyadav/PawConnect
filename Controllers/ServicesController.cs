using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PawConnect.Data;

namespace PawConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ServicesController(AppDbContext db)
        {
            _db = db;
        }

        // GET: /api/services
        // Optional: /api/services?category=Vet
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? category)
        {
            var query = _db.PetServices.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                var normalized = category.Trim().ToLower();
                query = query.Where(s => s.Category.ToLower() == normalized);
            }

            var services = await query
                .OrderBy(s => s.Category)
                .ThenBy(s => s.Name)
                .ToListAsync();

            return Ok(services);
        }

        // GET: /api/services/{id}
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var service = await _db.PetServices.FindAsync(id);
            if (service == null) return NotFound("Service not found.");

            return Ok(service);
        }
    }
}
