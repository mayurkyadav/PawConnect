using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PawConnect.Data;

namespace PawConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public PostsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: /api/posts
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _db.Posts
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();

            return Ok(posts);
        }

        // GET: /api/posts/1
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _db.Posts.FindAsync(id);
            if (post == null) return NotFound("Post not found.");

            return Ok(post);
        }
    }
}
