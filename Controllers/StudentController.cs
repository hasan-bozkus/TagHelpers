using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index() => View();

        [Route("student/{id:int}")]
        public IActionResult Detail(int id) => View();

        [Route("student/list", Name = "getlistroute")]
        public IActionResult GetList() => View();

        [Route("/student/filter", Name = "filterstudentroute")]
        public IActionResult GetList(int age, string name) => View();
    }
}
