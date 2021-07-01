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

        private IKeyRepository _keyRepository;

        private ITeacherRepository _teacherRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository, IKeyRepository keyRepository, ITeacherRepository teacherRepository)
        {
            _assignmentRepository = assignmentRepository;
            _keyRepository = keyRepository;
            _teacherRepository = teacherRepository;
        }

        public List<AssignmentDto> GetAssignments()
        {
            return _assignmentRepository.GetAssignments().Select(x => new AssignmentDto(x)).ToList();
        }

        public AssignmentDto InsertAssignment(AssignmentCreateRequestDto assignment)
        {
            var dtAssignment = assignment.ToModel();
            dtAssignment.Key = _keyRepository.GetKeyById(assignment.KeyID);
            dtAssignment.Teacher = _teacherRepository.GetTeacherById(assignment.TeacherID);
            var createdAssignment = new AssignmentDto(_assignmentRepository.InsertAssignment(dtAssignment));
            return createdAssignment;
        }
    }
}
