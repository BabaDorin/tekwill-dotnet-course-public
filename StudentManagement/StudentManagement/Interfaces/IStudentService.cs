using StudentManagement.Models;

namespace StudentManagement.Interfaces
{
    public interface IStudentService
    {
        void Add(Student student);

        Student Get(Guid id);

        List<Student> GetAll();

        void Delete(Guid id);

        void Update(Guid id, Student student);
    }
}
