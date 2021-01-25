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
        public IList<SchoolPlanner.Models.Task> Task { get; set; }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Subject = await _context.Subjects
                .Include(s => s.Teacher).ToListAsync();
            Exam = await _context.Exams
                .Include(e => e.Subject).ToListAsync();
            Task = await _context.Tasks
                .Include(t => t.Subject).ToListAsync();

        }
    }
}
