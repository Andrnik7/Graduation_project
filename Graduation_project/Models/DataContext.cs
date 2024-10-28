using Microsoft.EntityFrameworkCore;

namespace Graduation_project.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
          : base(options) { }
        public DbSet<Students> Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Current_grades_math> Current_Grades_maths { get; set; }
        public DbSet<Current_grades_biology> Current_Grades_biology { get; set; }
        public DbSet<Current_grades_world_history> Current_Grades_world_history { get; set; }
        public DbSet<Current_grades_computer_project> Current_Grades_computer_project { get; set; }
        public DbSet<Current_grades_english> Current_Grades_english { get; set; }
        public DbSet<Current_grades_geography> Current_Grades_geography { get; set; }
        public DbSet<Current_grades_informathicsIT> Current_Grades_informathicsIT { get; set; }
        public DbSet<Current_grades_PE> Current_Grades_PE { get; set; }
        public DbSet<Current_grades_physics> Current_Grades_physics { get; set; }
        public DbSet<Current_grades_programming> Current_Grades_programming { get; set; }
        public DbSet<Current_grades_ukr_history> Current_Grades_history { get; set; }
        public DbSet<Current_grades_ukr_lang> Current_Grades_ukr_lang { get; set; }
        public DbSet<Current_grades_ukr_lit> Current_Grades_ukr_lit { get; set; }
        public DbSet<Current_grades_world_lit> Current_Grades_world_lit { get; set; }
        public DbSet<Class_list> Class_list { get; set; }
        public DbSet<schedule_days> schedule_day { get; set; }

    }
}   
