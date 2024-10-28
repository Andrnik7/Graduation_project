using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class schedule_days
    {
        [Key]
        public int ID_schedule_day { get; set; }
        public int class_id { get; set; }
        public string day_name { get; set; }

        [ForeignKey("class_id")]
        public Class_list Class { get; set; }

        public string first_lesson { get; set; }
        public string second_lesson { get; set; }
        public string third_lesson { get; set; }
        public string fourth_lesson { get; set; } 
        public string fifth_lesson { get; set; }
    }
}
