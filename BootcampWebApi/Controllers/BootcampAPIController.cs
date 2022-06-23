using BootcampWebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BootcampWebApi.Data;

namespace BootcampWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BootcampAPIController : ControllerBase
    {
        private readonly DataContext _context;

        public BootcampAPIController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult UserAdd([FromBody] User user) // Post ve Update işlemlerine neden FromBody yaptık?
        {
            var createdUser = _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);

        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllBootcamps()
        {
            var bootcamps = _context.Bootcamps.ToList();
            return Ok(bootcamps);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetBootcampById(int id)
        {
            var bootcamp = _context.Bootcamps.Find(id);
            return Ok(bootcamp);
        }

        [HttpPost]
        [Route("[action]/{userId}/{bootcampId}")]
        public IActionResult BootcampJoin(int userId, int bootcampId) // Post ve Update işlemlerine neden FromBody yaptık?
        {
            var user = _context.Users.Find(userId);
            user.BootcampId = bootcampId;
            _context.SaveChanges();
            return Ok(user);

        }
    }
}
