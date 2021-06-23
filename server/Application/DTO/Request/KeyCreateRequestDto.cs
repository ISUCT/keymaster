namespace Application.DTO.Request
{
    using Application.Interfaces;
    using Domain.Models;

    public class KeyCreateRequestDto : IDtoMapper<Key>
    {
        public string Classroom { get; set; }

        public string QR { get; set; }

        public Teacher Teacher { get; set; }

        public Key ToModel()
        {
            return new Key()
            {
                Classroom = this.Classroom,
                QR = this.QR,
                Teacher = this.Teacher,
            };
        }
    }
}
