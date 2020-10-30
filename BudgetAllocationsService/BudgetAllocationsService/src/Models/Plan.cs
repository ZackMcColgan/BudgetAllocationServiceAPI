using System;
using System.Collections.Generic;

namespace BudgetAllocationsService.Models
{
    public sealed class Plan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Allocation> Allocations { get; set; }
    }
}
