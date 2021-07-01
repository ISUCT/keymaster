namespace Domain.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public System.DateTime Date { get; set; }

        public Key Key { get; set; }

        public Teacher Teacher { get; set; }

        public System.DateTime ReturnDate { get; set; }
    }
}
