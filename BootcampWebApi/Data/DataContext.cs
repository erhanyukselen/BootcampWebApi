using BootcampWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootcampWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Bootcamp> Bootcamps
        {
            get; set;
        }

        public DbSet<User> Users
        {
            get; set;
        }
        
        
    }
}

