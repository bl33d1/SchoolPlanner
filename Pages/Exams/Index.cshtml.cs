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
    public class IndexModel : PageModel
    {
        private readonly SchoolPlanner.Data.SchoolContext _context;

        public IndexModel(SchoolPlanner.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Exam> Exam { get;set; }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Exam = await _context.Exams
                .Include(e => e.Subject).ToListAsync();
        }
    }
}
