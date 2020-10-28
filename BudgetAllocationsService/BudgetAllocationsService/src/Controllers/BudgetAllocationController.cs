using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAllocationsService.Controllers
{
    public class BudgetAllocationController : Controller
    {
        [HttpGet("api/budgetAllocationsView/")]
        public async Task<IActionResult> GetBudgetAllocationsView()
        {

            return Ok(new { name = "Zack", id = Guid.NewGuid() });
        }
    }
}
