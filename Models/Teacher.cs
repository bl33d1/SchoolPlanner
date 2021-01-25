using System.ComponentModel.DataAnnotations;

namespace SchoolPlanner.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}