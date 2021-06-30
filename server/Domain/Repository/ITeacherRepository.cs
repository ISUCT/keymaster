namespace Domain.Repository
{
    using System.Linq;
    using Domain.Models;

    public interface ITeacherRepository
    {
        IQueryable<Teacher> GetTeachers();

        Teacher GetTeacherById(int id);

        Teacher InsertTeacher(Teacher teacher);
    }
}
