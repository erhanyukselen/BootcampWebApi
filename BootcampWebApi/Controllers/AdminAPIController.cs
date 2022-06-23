using BootcampWebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BootcampWebApi.Data;

namespace BootcampWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminAPIController : Controller
    {
        private readonly DataContext _context;

        public AdminAPIController(DataContext context)
        {
            _context = context;
        }

        //Action we use to add bootcamp
        [HttpPost]
        [Route("[action]")]
        public IActionResult BootcampAdd([FromBody] Bootcamp bootcamp) 
        {
            var createdBootcamp = _context.Bootcamps.Add(bootcamp);
            _context.SaveChanges();
            return Ok(bootcamp);

        }
        //Action we use to delete bootcamp
        [HttpDelete("BootcampDelete")]
        public void BootcampDelete(int id)
        {
            var deletedBootcamp = _context.Bootcamps.Find(id);
            _context.Bootcamps.Remove(deletedBootcamp);
            _context.SaveChanges();
        }

        //Action we use to to confirm participants
        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult UserAccept( int id)
        {
            var user = _context.Users.Find(id);
            user.Status = true;
            var updatedUser = _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        //Action we use to reject participants
        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult UserDrop( int id)
        {
            var user = _context.Users.Find(id);
            user.Status = false;
            var updatedUser = _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        //Action we use to delete participants
        [HttpDelete("UserDelete")]
        public void UserDelete(int id)
        {
            var deletedUser = _context.Users.Find(id);
            _context.Users.Remove(deletedUser);
            _context.SaveChanges();
        }

        
   
    }
}
