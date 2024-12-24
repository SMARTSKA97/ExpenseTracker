using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Core.Entities;

namespace ExpenseTracker.Infrastructure.Data
{
    public class ExpenseTrackerDbContext : DbContext
    {
        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
    }
}
