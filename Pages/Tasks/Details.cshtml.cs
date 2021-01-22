using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Data;
using SchoolPlanner.Models;

namespace SchoolPlanner2.Pages.Tasks
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public DetailsModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        public SchoolPlanner.Models.Task Task { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Task = await _context.Tasks
                .Include(t => t.Subject).FirstOrDefaultAsync(m => m.TaskID == id);

            if (Task == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
