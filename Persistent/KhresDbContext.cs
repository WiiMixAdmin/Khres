using Khres.Models;
using Microsoft.EntityFrameworkCore;

namespace Khres.Persistent
{
    public class KhresDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public KhresDbContext(DbContextOptions<KhresDbContext> options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            // Handle many to many by adding compound keys to third table
            modelBuilder.Entity<EmployeeLeave>().HasKey(el => new {
                el.EmployeeId, 
                el.LeaveId,
                el.LeaveTypeId
            });

            // Handle complex type
            modelBuilder.Entity<Leave>().OwnsOne(l => l.Detail);
        }        
    }
}