﻿namespace Application.ViewModels
{
    using Domain.Models;

    public class KeyDto
    {
        public KeyDto(Key key)
        {
            this.Id = key.Id;
            this.Classroom = key.Classroom;
            this.QR = key.QR;
            this.Teacher = key.Teacher;
        }

        public KeyDto()
        {
        }

        public int Id { get; set; }

        public string Classroom { get; set; }

        public string QR { get; set; }

        public Teacher Teacher { get; set; }
    }
}
