using Microsoft.AspNetCore.Mvc;
using SMS.DataRepositories;
using SMS.Models;
using System.Net.Http;

namespace SMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }


        [HttpGet]
        [Route("/GetAll")]
        public IEnumerable<Student> GetStuList()
        {
            return _studentRepository.GetAll();
        }
        

        [HttpGet]
        [Route("/GetTime")]

        public string GetServerTime()
        {
            return $"Server Time : {DateTime.Now}";
        }

        [Route("/Get/{id?}")]
        public string GetStu(int id)
        {
            return _studentRepository.GetStudent(id).Name;
        }

        [HttpGet]
        [Route("/Test")]
        public string GetStu()
        {
            return "服务器连接成功 !";
        }
    }
}
