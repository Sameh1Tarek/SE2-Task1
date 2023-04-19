using Microsoft.AspNetCore.Mvc;
using SE2.Models;

namespace SE2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1 ,Name="Sameh" },
                new Student{Id=2 ,Name="Ahmed" },
                new Student{Id=3 ,Name="Alaa" },
                new Student{Id=4 ,Name="Zeyad" }
            };
            return View(students);
        }
    }
}
