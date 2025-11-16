using CQRSAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSAssignment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students => Set<Student>();
    }
}
