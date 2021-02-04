using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.Details
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public DetailsModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Subject Subject { get; set; }
        public List<SchoolPlanner.Models.Task> Task {get; set;}

        public List<Exam> Exam { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subject = await _context.Subjects
                .Include(s => s.Teacher).FirstOrDefaultAsync(m => m.SubjectID == id);

            Task = await _context.Tasks
                .Include(t => t.Subject)
                .Where(t => t.SubjectID == id).ToListAsync();

            Exam = await _context.Exams
                .Include(t => t.Subject)
                .Where(t => t.SubjectID == id).ToListAsync();

            if (Subject == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
