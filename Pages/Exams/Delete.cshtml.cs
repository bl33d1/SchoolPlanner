using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.Exams
{
    public class DeleteModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public DeleteModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Exam Exam { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exam = await _context.Exams
                .Include(e => e.Subject).FirstOrDefaultAsync(m => m.ExamID == id);

            if (Exam == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exam = await _context.Exams.FindAsync(id);

            if (Exam != null)
            {
                _context.Exams.Remove(Exam);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
