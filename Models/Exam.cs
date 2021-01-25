using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPlanner.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        [Display(Name = "Subject")]
        public int SubjectID { get; set; }

        [Display(Name = "Date and Time")]
        public DateTime DateAndTime { get; set; }
        public string Room { get; set; }
        public Subject Subject { get; set; }
    }
}
