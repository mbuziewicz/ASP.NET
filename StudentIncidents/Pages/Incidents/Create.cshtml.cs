using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentIncidents.Data;
using StudentIncidents.Models;

namespace StudentIncidents.Pages.Incidents
{
    public class CreateModel : PageModel
    {
        private readonly StudentIncidents.Data.StudentIncidentsContext _context;

        public CreateModel(StudentIncidents.Data.StudentIncidentsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Incident Incident { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Incident.Add(Incident);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
