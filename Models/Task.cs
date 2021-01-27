using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPlanner.Models
{
    public enum TypeOfTask { 
        Assignment, Reminder, ToDoItem
    }
    public class Task
    {
        public int TaskID { get; set; }
        [Display(Name = "Subject")]
        public int SubjectID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Detail { get; set; }
        [Display(Name = "Type of task")]
        public TypeOfTask TypeOfTask { get; set; }
        [Display(Name = "Due date")]
        public DateTime DueDate { get; set; }
        public bool isDone { get; set; }
        public Subject Subject { get; set; }
    }
}
