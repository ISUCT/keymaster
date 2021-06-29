namespace Application.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.DTO.Request;
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Repository;

    public class AssignmentService : IAssignmentService
    {
        private IAssignmentRepository _assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public List<AssignmentDto> GetAssignments()
        {
            return _assignmentRepository.GetAssignments().Select(x => new AssignmentDto(x)).ToList();
        }

        public AssignmentDto InsertAssignment(AssignmentCreateRequestDto assignment)
        {
            var dtAssignment = assignment.ToModel();
            var createdAssignment = new AssignmentDto(_assignmentRepository.InsertAssignment(assignment.ToModel()));
            return createdAssignment;
        }
    }
}
