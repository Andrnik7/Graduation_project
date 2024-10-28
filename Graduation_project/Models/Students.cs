using System.ComponentModel.DataAnnotations;
namespace Graduation_project.Models
{
    public class Students
    {
        [Key]
        public int ID_student { get; set; }
        public string? Name_student { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Surname_student { get; set; }
        public string? Form { get; set; }
        public int Count_grades { get; set; }
        public int Average_grage { get; set; }
        public int Position_in_class {  get; set; }
        public int Position_in_paralel {  get; set; }
        public Attendance? Attendance { get; set; }
    }

}
