using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindMyUsers.Models;

namespace FindMyUsers.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersContext _context;

        public UsersController(UsersContext context)
        {
            _context = context;

        }

        // GET: api/Users
        // GET: api/Users?first=John
        // GET: api/Users?first=John&last=Beast
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(string first, string last, string interests)
        {
            var users = from u in _context.Users
                        select u;

            if (!string.IsNullOrEmpty(first))
            {
                users = users.Where((User user) => user.First.Contains(first));   
            }
            if (!string.IsNullOrEmpty(last))
            {
                users = users.Where((User user) => user.Last.Contains(last));
            }
            if (!string.IsNullOrEmpty(interests))
            {
                users = users.Where((User user) => user.Interests.Contains(interests));
            }


            if (users.Any())
            {
                return await users.ToListAsync();
            }
            else
            {
                return NoContent();
            }

        }


        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }




        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}