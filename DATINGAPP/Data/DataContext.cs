using DATINGAPP.Entities;
using Microsoft.EntityFrameworkCore;

namespace DATINGAPP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
