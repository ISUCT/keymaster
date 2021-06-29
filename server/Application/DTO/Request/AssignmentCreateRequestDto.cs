namespace Application.DTO.Request
{
    using Application.Interfaces;
    using Domain.Models;

    public class AssignmentCreateRequestDto : IDtoMapper<Assignment>
    {
        public int KeyID { get; set; }

        public int TeacherID { get; set; }

        public Assignment ToModel()
        {
            return new Assignment()
            {
                Date = System.DateTime.Now,
            };
        }
    }
}
