using _05_ModelBlinding.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_ModelBlinding.Controllers
{

    //viewmodel 
    // dto => data transfer object
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "Werner", Surname = "Heisenberg" });
            students.Add(new Student() { Name = "Baris", Surname = "Gun" });
            students.Add(new Student() { Name = "Oppen", Surname = "Heimer" });

            return View(students);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Student student, int TCKN)
        //{
        //    return View();
        //}

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost()
        {
            Student student = new Student();
            student.Name = Request.Form["Name"];
            student.Surname = Request.Form["Surname"];

            int tckn = int.Parse(Request.Form["TCKN"]);

            return View();
        }
    }
}
