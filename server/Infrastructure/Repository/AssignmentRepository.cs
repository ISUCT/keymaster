namespace CleanArchitecture.Infra.Data.Repositories
{
    using System.Linq;
    using Domain.Models;
    using Domain.Repository;
    using Infrastructure.EF;
    using Microsoft.EntityFrameworkCore;

    public class AssignmentRepository : IAssignmentRepository
    {
        private DatabaseContext context;

        public AssignmentRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Assignment InsertAssignment(Assignment assignment)
        {
            var entity = context.Add(assignment);
            context.SaveChanges();
            return entity.Entity;
        }

        IQueryable<Assignment> IAssignmentRepository.GetAssignments()
        {
            return context.Assignments.AsNoTracking();
        }
    }
}
