using Advance_Library_Management_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Advance_Library_Management_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories {get; set;}
    }
}
