using Microsoft.AspNetCore.Mvc;
using SMS.DataRepositories;
using SMS.Models;

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
        [Route("/GetTime")]

        public string GetServerTime()
        {
            return $"Server Time : {DateTime.Now}";
        }
    }
}
