using LMS.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.API.Data
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveConsumed> LeavesConsumed { get; set; }

        
    }
}
