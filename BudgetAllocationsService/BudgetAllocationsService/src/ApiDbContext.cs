using BudgetAllocationsService.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetAllocationsService
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        // TODO: Add ability to store: Allocations, People, Plan, and Projects
        // Initialize Budget to $10,000 on startup

        //public DbSet<ConversationEntity> Conversations { get; set; }

        //public DbSet<CommentEntity> Comments { get; set; }
    }
}
