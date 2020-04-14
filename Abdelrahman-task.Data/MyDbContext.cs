using Abdelrahman_task.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abdelrahman_task.Data
{
    public class MyDbContext : IdentityDbContext<user>
    { 

        public DbSet<Student> Students { get; set; }
    public DbSet<Fucalty> Fucalties { get; set; }
    public MyDbContext(DbContextOptions options)
   : base(options)
    {

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
