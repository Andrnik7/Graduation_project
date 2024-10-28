using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Graduation_project.Models
{
    public class Current_grades_ukr_history
    {
        [Key]
        public int ID_ukr_history { get; set; }
        public string? date { get; set; }
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string? type_grade { get; set; }
        [ForeignKey("Student")]
        public int ID_student { get; set; }
        public Students? Student { get; set; }
    }
}
