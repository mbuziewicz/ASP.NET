using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Data;
using StudentIncidents.Models;

namespace StudentIncidents.Pages.Incidents
{
    public class DeleteModel : PageModel
    {
        private readonly StudentIncidents.Data.StudentIncidentsContext _context;

        public DeleteModel(StudentIncidents.Data.StudentIncidentsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Incident Incident { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Incident = await _context.Incident.FirstOrDefaultAsync(m => m.ID == id);

            if (Incident == null)
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

            Incident = await _context.Incident.FindAsync(id);

            if (Incident != null)
            {
                _context.Incident.Remove(Incident);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
