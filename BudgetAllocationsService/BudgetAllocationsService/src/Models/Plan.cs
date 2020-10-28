using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BudgetAllocationsService.Models
{
    public sealed class Plan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Allocation> Allocations { get; set; }

    }
}
