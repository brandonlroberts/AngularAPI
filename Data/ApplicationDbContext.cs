using AngularAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Movie> movies { get; set; } 
    }
}
