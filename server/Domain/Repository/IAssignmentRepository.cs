namespace Domain.Repository
{
    using System.Linq;
    using Domain.Models;

    public interface IAssignmentRepository
    {
        IQueryable<Assignment> GetAssignments();

        Assignment InsertAssignment(Assignment assignment);
    }
}
