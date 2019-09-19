using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindMyUsers.Models;
using FindMyUsers.Repository;

namespace FindMyUsers.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly UsersContext _context;
        private IUsersRepository userRepo;

        public UsersController(IUsersRepository userRepository)
        {
            this.userRepo = userRepository;
        }


        // GET: api/Users
        // GET: api/Users?first=John
        // GET: api/Users?first=John&last=Beast
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(string first, string last, string interests)
        {

            IQueryable<User> users = userRepo.FindByCondition(first, last, interests);


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
        public ActionResult<User> GetUser(long id)
        {
            IQueryable<User> user = userRepo.FindById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user.FirstOrDefault();
        }




        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await userRepo.Create(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}