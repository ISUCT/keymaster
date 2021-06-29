namespace Domain.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public System.DateTime Date { get; set; }

        public int KeyID { get; set; }

        public int TeacherID { get; set; }

        public System.DateTime ReturnDate { get; set; }
    }
}
