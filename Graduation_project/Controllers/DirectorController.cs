using Graduation_project.Migrations;
using Graduation_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation_project.Controllers
{
    public class DirectorController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly DataContext _context;
        public DirectorController(ILogger<LoginController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult login_director()
        {
            return View();
        }
        public IActionResult Settings_for_director()
        {
            var director = _context.Teachers.FirstOrDefault(t => t.is_admin == true);
            return View(director);
        }
        [HttpPost]
        public async Task<IActionResult> Login_to_dashboard(string Director_username, string Director_password)
        {
            if (ModelState.IsValid)
            {

                if (string.IsNullOrEmpty(Director_username) || string.IsNullOrEmpty(Director_password))
                {
                    ModelState.AddModelError("", "Будь ласка, заповніть всі поля.");
                    return View();
                }
                var director = await _context.Teachers
               .Where(t => t.user_teacher == Director_username && t.password_teacher == Director_password && t.is_admin == true)
               .FirstOrDefaultAsync();
                if (director != null)
                {
                    return RedirectToAction("Settings_for_director");
                }
                else
                {
                    ModelState.AddModelError("", "Невірний логін або пароль, або у вас немає прав адміністратора.");
                    return View();
                }
            }
            return View();
        }
        public IActionResult Manage_schedule()
        {
            var model = new Schedule_view
            {
                Classes = _context.Class_list.ToList(),
                Teachers = _context.Teachers.ToList(),
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveSchedule()
        {
            int selectedClassId = Convert.ToInt32(Request.Form["class_id"]);
            var daysOfWeek = new[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця" };
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                var daySchedule = new schedule_days
                {
                    class_id = selectedClassId,
                    day_name = daysOfWeek[i],
                    first_lesson = Request.Form[$"lessons[0][{i}].Subject"],
                    second_lesson = Request.Form[$"lessons[1][{i}].Subject"],
                    third_lesson = Request.Form[$"lessons[2][{i}].Subject"],
                    fourth_lesson = Request.Form[$"lessons[3][{i}].Subject"],
                    fifth_lesson = Request.Form[$"lessons[4][{i}].Subject"]
                };
                _context.schedule_day.Add(daySchedule);
            }
            _context.SaveChanges();
            return RedirectToAction("Manage_schedule");
        }
    }
}
