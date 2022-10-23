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
        IEnumerable<Student> GetAll();
        int Count();
        
    }

    public class StudentRepository : IStudentRepository
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }


        IEnumerable<Student> IStudentRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
