using BudgetAllocationsService.Controllers;
using BudgetAllocationsService.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BudgetAllocationsService.Test
{
    [TestClass]
    public class BudgetAllocationControllerTests
    {
        private BudgetAllocationController _controller;
        private IBudgetAllocationRepository _repository;

        private IBudgetAllocationRepository GetInMemoryRepository()
        {
            var options = new DbContextOptionsBuilder<BudgetAllocationContext>()
                             .UseInMemoryDatabase(databaseName: "MockDB")
                             .Options;

            var context = new BudgetAllocationContext(options);

            var repository = new DbRepository(context);

            return repository;
        }


        [TestInitialize]
        public void Setup()
        {
            _repository = GetInMemoryRepository();// new Mocks.MockRepository();
            _controller = new BudgetAllocationController(_repository);
        }

        [TestMethod]
        public async void Create()
        {
            await _controller.CreateNewAllocation(); // TODO: Pass in needed data for new allocation here

            /* Asserts here
            Assert.AreEqual(1, _repository.Books.Count());
            Assert.AreEqual("Jane Austen", _repository.Books.First().Author.Name);
            Assert.AreEqual(1, _repository.Authors.Count());
            Assert.AreEqual("Emma", _repository.Authors.First().Books.First().Title);
            */
        }
    }
}
