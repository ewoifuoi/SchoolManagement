using SMS.Models;
namespace SMS.DataRepositories
{
    public class MockStudentRepository : IStudentRepository
    {
        private readonly List<Student> _studentList;
        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "张三", Major="计算机", Email="2333@ffs.com"},
                new Student() { Id = 2, Name = "李四", Major="计算机", Email="23pllppl33@ffs.com"},
                new Student() { Id = 3, Name = "王五", Major="计算机", Email="233qwqiwjn3@ffs.com"},
                new Student() { Id = 4, Name = "Momo", Major="计算机", Email="23pppp33@ffs.com"},
                new Student() { Id = 5, Name = "可莉", Major="计算机", Email="2fwefe3@ffs.com"},
                new Student() { Id = 6, Name = "Bob", Major="计算机", Email="23grgrr3@ffs.com"}

            };
        }
        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(a => a.Id == id);
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        

        public IEnumerable<Student> GetAll()
        {
            return _studentList;
        }
    }


}
