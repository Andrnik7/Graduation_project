using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Graduation_project.Models
{
    public class Teachers
    {
        [Key]
        public int ID_teacher { get; set; }
        public string? Name_teacher { get; set; }
        public string? Surname_teacher { get; set; }
        public string? MiddleName_teacher { get; set; }
        public string Subject { get; set; }
        public bool? is_form_master { get; set; }
        public string? form_master_class { get; set; }
        public string? user_teacher { get; set; }
        public string? password_teacher { get; set; }
        public bool? is_admin { get; set; }

    }
}
