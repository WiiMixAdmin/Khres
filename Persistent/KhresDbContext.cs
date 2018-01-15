using Khres.Models;
using Microsoft.EntityFrameworkCore;

namespace Khres.Persistent
{
    public class KhresDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public KhresDbContext(DbContextOptions<KhresDbContext> options)
            :base(options)
        {
            
        }        
    }
}