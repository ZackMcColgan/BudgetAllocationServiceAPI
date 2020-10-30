using System.Linq;

namespace BudgetAllocationsService.Models
{
    public interface IBudgetAllocationRepository
    {
        public IQueryable<Project> Projects { get; }
        public IQueryable<Person> People { get; }

        void Add<EntityType>(EntityType entity);

        void SaveChanges();
    }
}
