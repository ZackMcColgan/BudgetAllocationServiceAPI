using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAllocationsService.Models
{
    public class DbRepository : IBudgetAllocationRepository
    {
        private readonly BudgetAllocationContext _db;

        public DbRepository(BudgetAllocationContext db)
        {
            _db = db;
        }

        public IQueryable<Person> People => _db.People;
        public IQueryable<Project> Projects => _db.Projects;

        public void Add<EntityType>(EntityType entity) => _db.Add(entity);
        public void SaveChanges() => _db.SaveChanges();
    }
}
