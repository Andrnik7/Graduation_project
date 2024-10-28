using Graduation_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace Graduation_project.Controllers
{
    public class Student_grade_managmentController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly DataContext _context;
        public class AddLessonViewModel
        {
            public IEnumerable<Class_list> Classes { get; set; }
            public IEnumerable<Students> Students { get; set; }
            public IEnumerable<schedule_days> schedules { get; set; }
            public string Subject { get; set; }
            public int Teacher_ID { get; set; }
        }
        public Student_grade_managmentController(ILogger<LoginController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Main_page()
        {
            return View();
        }
        public IActionResult Sign_in_teacher()
        {
            return View();
        }
        public IActionResult Login_to_editor(string TeacherUsername, string TeacherPassword)
        {
            var teachers = _context.Teachers.ToList();
            var teacher = teachers.FirstOrDefault(t =>
                t.user_teacher.Trim() == TeacherUsername &&
                t.password_teacher.Trim() == TeacherPassword);
            if (teacher != null)
            {
                var subject = teacher.Subject;
                string teacher_id = Convert.ToString(teacher.ID_teacher);
                HttpContext.Session.SetString("Teacher_ID", teacher_id);
                HttpContext.Session.SetString("Teacher_subject", subject);
                return RedirectToAction("Editor_grades");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Невірний логін або пароль");
                return View();
            }
        }
        public IActionResult Editor_Grades()
        {
            var subject = HttpContext.Session.GetString("Teacher_subject");
            ViewBag.Subject = subject;
            var teacher_ID = HttpContext.Session.GetString("Teacher_ID");
            ViewBag.teacher_ID = teacher_ID;
            var classes = _context.Class_list.ToList();
            return View(classes);
        }
        [HttpGet]
        public IActionResult Edit_for_class(string class_name)
        {
            ViewBag.ClassName = class_name;
            var studentsInClass = _context.Students
                                      .Where(s => s.Form == class_name)
                                      .ToList();
            return View(studentsInClass);
        }
        [HttpGet]
        public IActionResult Add_grade(int student_id)
        {
            var subject = HttpContext.Session.GetString("Teacher_subject");
            ViewBag.Subject = subject;
            var teacher_ID = HttpContext.Session.GetString("Teacher_ID");
            ViewBag.teacher_ID = teacher_ID;
            ViewBag.Student_ID = student_id;
            var student = _context.Students.FirstOrDefault(s => s.ID_student == student_id);
            ViewBag.StudentSurname = student.Surname_student;
            return View();
        }
        [HttpPost]
        public IActionResult Add_grade()
        {
            return RedirectToAction("Add_grade");
        }
        public IActionResult Add_lesson(string subject, int teacher_ID)
        {
            var classes = _context.Class_list.ToList();
            var students = _context.Students.ToList();
            var schedules = _context.schedule_day.ToList();
            var viewModel = new AddLessonViewModel
            {
                Classes = classes,
                Students = students,
                Subject = subject,
                Teacher_ID = teacher_ID,
                schedules = schedules
            };
            return View(viewModel);
        }
    }
}
