using SchoolPlanner.Data;
using SchoolPlanner.Models;
using System;
using System.Linq;

namespace SchoolPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Teachers.Any())
            {
                return;
            }
            else
            {
                var teachers = new Teacher[]
{
                new Teacher{Name="Xhelal"},
                new Teacher{Name="Vesa"}
};
                context.Teachers.AddRange(teachers);
                context.SaveChanges();
            }

            // Look for any Subjects.
            if (context.Subjects.Any())
            {
                //return;   // DB has been seeded
            }

            var Subjects = new Subject[]
            {
                //new Subject{Name="Matematik",Time="13:00",TeacherID=1},

            };

            //context.Subjects.AddRange(Subjects);
            //context.SaveChanges();

            var tasks = new Task[]
            {
                //new Task{SubjectID=1,Title="Task 1",Date="Monday"},

            };

            //context.Tasks.AddRange(tasks);
            //context.SaveChanges();



        }
    }
}