using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BudgetAllocationsService.Models
{
    public class Allocation
    {
        private protected Guid id { get; set; }

        private protected Guid projectID { get; set; }

        private protected Guid personID { get; set; }

        private protected string name { get; set; }

        private protected string timeCreated { get; set; }
    }
}
