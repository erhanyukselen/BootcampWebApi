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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] {
                new User{Id=1,Name="Ahmet",Status=false},
                new User{Id=2,Name="Mehmet",Status=false},
                new User{Id=3,Name="Enes",Status=false},
            });

            modelBuilder.Entity<Bootcamp>().HasData(new Bootcamp[] {
                new Bootcamp{Id=1,Name="Arvato1",Date=DateTime.UtcNow},
                new Bootcamp{Id=2,Name="Arvato2",Date=DateTime.UtcNow},
                new Bootcamp{Id=1,Name="Arvato3",Date=DateTime.UtcNow},

            });
        }

    }
}

