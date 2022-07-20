using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var Student = new List<Student>();
            using (var context = new studentContext())
            {
                Student = context.Students.ToList();
            }
            return Student;
        }
    }
}