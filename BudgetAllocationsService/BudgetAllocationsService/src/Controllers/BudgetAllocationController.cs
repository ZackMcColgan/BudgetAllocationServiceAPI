using BudgetAllocationsService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAllocationsService.Controllers
{
    public class BudgetAllocationController : Controller
    {
        private readonly IBudgetAllocationRepository _repository;

        public BudgetAllocationController(IBudgetAllocationRepository repository)
        {
            _repository = repository;
        }

        // TODO: Make this endpoint accept an ID as input
        [HttpGet("api/budgetAllocationsView/")]
        public async Task<IActionResult> GetBudgetAllocationsView()
        {
            // TODO: Call function to get the view here
            return Ok(new { name = "Zack", id = Guid.NewGuid() });
        }

        // TODO: Make this endpoint accept a new allocation
        [HttpPost("api/addAllocation/")]
        public async Task<IActionResult> CreateNewAllocation()
        {
            // TODO: Call function to create new allocation here
            return Ok(new { name = "Zack", id = Guid.NewGuid() });
        }
    }
}
