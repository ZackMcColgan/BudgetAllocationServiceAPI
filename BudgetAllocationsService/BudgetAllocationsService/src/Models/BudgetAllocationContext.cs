using Microsoft.EntityFrameworkCore;

namespace BudgetAllocationsService.Models
{
    public class BudgetAllocationContext : DbContext
    {
        public BudgetAllocationContext(DbContextOptions<BudgetAllocationContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
