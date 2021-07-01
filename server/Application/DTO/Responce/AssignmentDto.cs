namespace Application.ViewModels
{
    using Domain.Models;

    public class AssignmentDto
    {
        public AssignmentDto(Assignment assignment)
        {
            this.Id = assignment.Id;
            this.Date = assignment.Date;
            this.KeyID = assignment.Key.Id;
            this.TeacherID = assignment.Teacher.Id;
            this.ReturnDate = assignment.ReturnDate;
        }

        public AssignmentDto()
        {
        }

        public int Id { get; set; }

        public System.DateTime Date { get; set; }

        public int KeyID { get; set; }

        public int TeacherID { get; set; }

        public System.DateTime ReturnDate { get; set; }
    }
}
