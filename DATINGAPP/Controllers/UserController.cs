using DATINGAPP.Data;
using DATINGAPP.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DATINGAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext context;

        public UserController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            return await context.AppUsers.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<AppUser> GetUsersById(int id)
        {
            return await context.AppUsers.FindAsync(id);
        }
    }
}

