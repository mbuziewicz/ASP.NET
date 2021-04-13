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
    public class IndexModel : PageModel
    {
        private readonly StudentIncidents.Data.StudentIncidentsContext _context;

        public IndexModel(StudentIncidents.Data.StudentIncidentsContext context)
        {
            _context = context;
        }

        public IList<Parent> Parent { get;set; }

        public async Task OnGetAsync()
        {
            Parent = await _context.Parent.ToListAsync();
        }
    }
}
