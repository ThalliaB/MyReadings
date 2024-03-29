using Microsoft.EntityFrameworkCore;
using MyReadings.Models;

namespace MyReadings.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  
        }

        public DbSet<MyReadingsModel> MyReadings { get; set; }
    }
}
