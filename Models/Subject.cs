using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPlanner.Models
{
    public class Subject
    {
        
        public int SubjectID { get; set; }
        [Display(Name = "Subject")]
        public string Name { get; set; }
        [Display(Name = "Day")]
        public string Day { get; set; }
        [Display(Name = "Start time")]
        public string StartTime { get; set; }
        [Display(Name = "End time")]
        public string EndTime { get; set; }
        [Display(Name = "Subjects Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
