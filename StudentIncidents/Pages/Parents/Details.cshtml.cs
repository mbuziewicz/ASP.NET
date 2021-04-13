using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Data;
using StudentIncidents.Models;

namespace StudentIncidents.Pages.Parents
{
    public class DetailsModel : PageModel
    {
        private readonly StudentIncidents.Data.StudentIncidentsContext _context;

        public DetailsModel(StudentIncidents.Data.StudentIncidentsContext context)
        {
            _context = context;
        }

        public Parent Parent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parent = await _context.Parent.FirstOrDefaultAsync(m => m.ID == id);

            if (Parent == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
