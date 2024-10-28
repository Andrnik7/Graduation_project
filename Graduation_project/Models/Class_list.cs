using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class Class_list
    {
        [Key]
        public int ID_class { get; set; }
        public string? name_class { get; set; }
        public int biology_teacher { get; set; }
        public int math_teacher { get; set; }
        public int world_history_teacher { get; set; }
        public int computer_project_teacher { get; set; }
        public int english_project_teacher { get; set; }
        public int geography_teacher { get; set; }
        public int informathicsIT_teacher { get; set; }
        public int PE_teacher { get; set; }
        public int physics_teacher { get; set; }
        public int programming_teacher { get; set; }
        public int ukr_history_teacher { get; set; }
        public int ukr_lang_teacher { get; set; }
        public int ukr_lit_teacher { get; set; }
        public int world_lit_teacher { get; set; }

        public int ID_teacher { get; set; } 
        [ForeignKey("ID_teacher")]
        public Teachers Teacher { get; set; } 
    }
}
