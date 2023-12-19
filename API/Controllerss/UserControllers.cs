using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
namespace API.controllers;


[ApiController]
[Route("api/[controller]")]//api
public class UserController : ControllerBase
{
   private readonly DataContext _context;

   public UserController(DataContext context)
   {
    _context = context;
   }

   [HttpGet] 
   public ActionResult<IEnumerable<AppUser>> GetUsers()// users find
   {
      var users = _context.Users.ToList();

      return users;     
   }
             
   [HttpGet("{id}")] // find by id >> users

   public ActionResult<AppUser>GetUser(int id)

   {
     return _context.Users.Find(id);

   }
}
