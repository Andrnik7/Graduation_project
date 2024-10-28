using Graduation_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Graduation_project.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly DataContext _context;
        public LoginController(ILogger<LoginController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        private string Teacher_username;
        public IActionResult Sign_in()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> login_to_account(Students loginModel)
        {
            if (ModelState.IsValid)
            {
                var students = await _context.Students.ToListAsync();
                Students? student = null;
                foreach (var s in students)
                {
                    if (s.Username == loginModel.Username && s.Password == loginModel.Password)
                    {
                        student = s;
                        break;
                    }
                }
                if (student != null)
                {
                    return RedirectToAction("Main_page", "Student_grade_managment");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Check_teachers_credential(string TeacherName, string TeacherSurname, string TeacherUsername, string TeacherPassword)
        {
            var teachers = _context.Teachers.ToList();
            var teacher = teachers.FirstOrDefault(t =>
                t.Name_teacher.Trim() == TeacherName &&
                t.Surname_teacher.Trim() == TeacherSurname &&
                t.user_teacher.Trim() == TeacherUsername &&
                t.password_teacher.Trim() == TeacherPassword &&
                t.is_form_master == true);
            if (teacher != null)
            {
                HttpContext.Session.SetString("Teacher_username", TeacherUsername);
                return RedirectToAction("Register_Student");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Невірні дані для входу");
                return View();
            }
        }
        public IActionResult Verify_teacher()
        {
            return View();
        }
        public IActionResult Register(string Name_student, string Surname_student, string Username, string Password, string Form)
        {
            string? Teacher_username = HttpContext.Session.GetString("Teacher_username");
            var teacher = _context.Teachers.FirstOrDefault(t => t.user_teacher == Teacher_username);
            if (teacher != null && teacher.form_master_class == Form)
            {
                var student = new Students
                {
                    Name_student = Name_student,
                    Surname_student = Surname_student,
                    Username = Username,
                    Password = Password,
                    Form = Form
                };
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            ModelState.AddModelError("", "Невірний клас або вчитель не знайдений.");
            return View();
        }
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register_Student()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
