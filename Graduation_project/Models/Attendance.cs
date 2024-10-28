using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Graduation_project.Models
{
    public class Attendance
    {
        [Key, ForeignKey("Student")]
        public int ID_student { get; set; }
        public Students? Student { get; set; }
        public int attendent_lessons { get; set; }
        public int missed_lessons { get; set; }
        public int all_lessons { get; set; }
        public string? full_name_teacher { get; set; }
    }
}
