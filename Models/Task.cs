using System;
using System.Collections.Generic;
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
        public int SubjectID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public TypeOfTask TypeOfTask { get; set; }
        public DateTime DueDate { get; set; }
        public Subject Subject { get; set; }
    }
}
