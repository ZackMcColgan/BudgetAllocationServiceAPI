using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BudgetAllocationsService.Models
{
    public sealed class Allocation
    {
        public Guid id { get; set; }

        public Guid projectID { get; set; }

        public Guid personID { get; set; }

        public string name { get; set; }

        public DateTimeOffset timeCreated { get; set; }
    }
}
