using BudgetAllocationsService;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace BudgetAllocationService.UserTests
{
    public class UserTests 
    {
        private readonly HttpClient _client;

        /*
         * TODO: Make this work in .net core
          As a user, I start with $10,000 to allocate.
          As a user, I can see how much money is available to allocate.
          As a user, I cannot allocate more money than I have available.
          As a user, I can allocate money to a project (no person specified).
          As a user, I can view the allocations grouped by person or project.
          As a user, I can allocate money to a person (no project specified).
          As a user, I can allocate money to a person and a project.
          As a user, I can update allocations that I have already made.
          As a user, I can view a history of all the changes that I have made to the budget.
         */

        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }

        [Fact]
        public void Test1()
        {
          // var response =  _client.GetAsync(ApiRoutes.)
        }
    }
}
