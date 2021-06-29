﻿namespace Application.DTO.Request
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
                KeyID = this.KeyID,
                TeacherID = this.TeacherID,
                Date = System.DateTime.Now,
            };
        }
    }
}
