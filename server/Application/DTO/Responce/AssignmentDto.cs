namespace Application.ViewModels
{
    using Domain.Models;

    public class AssignmentDto
    {
        public AssignmentDto(Assignment assignment)
        {
            this.Id = assignment.Id;
            this.Date = assignment.Date;
            this.KeyID = assignment.KeyID;
            this.TeacherID = assignment.TeacherID;
            this.IsReturned = assignment.IsReturned;
        }

        public AssignmentDto()
        {
        }

        public int Id { get; set; }

        public System.DateTime Date { get; set; }

        public int KeyID { get; set; }

        public int TeacherID { get; set; }

        public bool IsReturned { get; set; }
    }
}
