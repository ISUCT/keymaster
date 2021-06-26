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
                KeyID = this.TeacherID,
                TeacherID = this.KeyID,
                Date = System.DateTime.Now,
                IsReturned = false,
            };
        }
    }
}
