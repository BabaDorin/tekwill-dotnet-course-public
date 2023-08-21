using StudentManagement.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> students;

        public StudentService()
        {
            students = new List<Student>();
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Delete(Guid id)
        {
            var toRemove = students.First(x => x.Id == id);

            students.Remove(toRemove);
        }

        public Student Get(Guid id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public void Update(Guid id, Student student)
        {
            var studentToUpdate = students.First(x => x.Id == id);

            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
        }
    }
}
