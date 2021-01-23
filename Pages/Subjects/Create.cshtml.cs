using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.Subjects
{
    public class CreateModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public CreateModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["TeacherID"] = new SelectList(_context.Teachers, "TeacherID", "TeacherID");
            return Page();
        }

        [BindProperty]
        public Subject Subject { get; set; }

        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {

            int endTime = int.Parse(Subject.EndTime.ToString());
            int startTime = int.Parse(Subject.StartTime.ToString());
            if (endTime < startTime || endTime == startTime)
            {
                yield return new ValidationResult("End time cant be less than Start time");
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Subjects.Add(Subject);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
