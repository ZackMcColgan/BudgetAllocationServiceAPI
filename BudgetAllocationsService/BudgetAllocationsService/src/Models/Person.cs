using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BudgetAllocationsService.Models
{
    public sealed class Person
    {
        public Guid id { get; set; }
        public string name { get; set; }
    }
}
