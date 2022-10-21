namespace SMS.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Email { get; set; }
    }

    public interface IStudentRepository
    {
        Student GetStudent(int id);
        void Save(Student student);
    }

    public class StudentRepository : IStudentRepository
    {
        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
