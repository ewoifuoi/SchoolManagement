using Microsoft.AspNetCore.Mvc;

namespace SMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        public string test()
        {
            return "test";
        }

        [HttpGet]
        [Route("/GetTime")]

        public string GetServerTime()
        {
            return $"Server Time : {DateTime.Now}";
        }
    }
}
