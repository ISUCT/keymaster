namespace Application.Interfaces
{
    using System.Collections.Generic;
    using Application.DTO.Request;
    using Application.ViewModels;

    public interface IAssignmentService
    {
        List<AssignmentDto> GetAssignments();

        AssignmentDto InsertAssignment(AssignmentCreateRequestDto assignment);
    }
}
