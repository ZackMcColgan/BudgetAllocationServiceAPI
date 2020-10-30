using System;
using System.Threading;
using System.Threading.Tasks;
using BudgetAllocationsService.Models;

namespace BudgetAllocationsService.Services
{
    public sealed class DefaultBudgetAllocationService : IBudgetAllocationService
    {
        private readonly BudgetAllocationContext _context;

        public DefaultBudgetAllocationService(BudgetAllocationContext context)
        {
            _context = context;
        }

        // budgetAllocationsView
        /*
        public async Task<CommentResource> GetBudgetAllocationViewAsync(Guid id, CancellationToken ct)
        {
            var entity = await _context
                .Comments
                .SingleOrDefaultAsync(x => x.Id == id, ct);

            return Mapper.Map<CommentResource>(entity);
        }
        */
    }
}
