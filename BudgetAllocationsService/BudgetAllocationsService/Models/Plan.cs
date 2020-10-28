using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BudgetAllocationsService.Models
{
    public class Plan
    {
        private protected Guid Id { get; set; }

        private protected string Name { get; set; }

        private protected List<Allocation> Allocations { get; set; }

    }
}
