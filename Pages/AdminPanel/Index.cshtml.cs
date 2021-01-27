using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.AdminPanel
{
    public class IndexModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public IndexModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Subject> Subject { get;set; }
        public IList<Exam> Exam { get; set; }
        [BindProperty]
        public IList<SchoolPlanner.Models.Task> Task { get; set; }

        public IList<SchoolPlanner.Models.Task> TaskDone { get; set; }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Subject = await _context.Subjects
                .Include(s => s.Teacher).ToListAsync();
            
            Exam = await _context.Exams
                .Include(e => e.Subject).ToListAsync();
            Exam = Exam.OrderBy(o => o.DateAndTime).ToList();

            Task = await _context.Tasks
                .Include(t => t.Subject)
                .Where(t => t.isDone == false).ToListAsync();
            //Task = Task.OrderBy(o => o.DueDate).ToList();

        }

        public RedirectToPageResult Complete(SchoolPlanner.Models.Task item)
        {
            SchoolPlanner.Models.Task originalItem = Task.SingleOrDefault(x => x.TaskID == item.TaskID);
            originalItem.isDone = true;

            return RedirectToPage("./Index");
        }


    }
}
