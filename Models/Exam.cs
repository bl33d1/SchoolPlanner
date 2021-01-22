using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPlanner.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        public int SubjectID { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Room { get; set; }
        public Subject Subject { get; set; }
    }
}
