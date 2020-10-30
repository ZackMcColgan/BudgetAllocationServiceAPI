using System;

namespace BudgetAllocationsService.Models
{
    public class Allocation
    {
        public Guid id { get; set; }

        public Guid projectID { get; set; }

        public Guid personID { get; set; }

        public string name { get; set; }

        public DateTimeOffset timeCreated { get; set; }
    }
}
