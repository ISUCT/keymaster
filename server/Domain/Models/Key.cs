namespace Domain.Models
{
    public class Key
    {
        public int Id { get; set; }

        public string Classroom { get; set; }

        public string QR { get; set; }

        public Teacher Teacher { get; set; }
    }
}
