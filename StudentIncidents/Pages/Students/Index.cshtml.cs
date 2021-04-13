using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Data;
using StudentIncidents.Models;

namespace StudentIncidents.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentIncidents.Data.StudentIncidentsContext _context;

        public IndexModel(StudentIncidents.Data.StudentIncidentsContext context)
        {
            _context = context;
        }

        public StudentIndexData StudentData { get; set; }

        public IList<Student> Student { get;set; }
        public int InstructorID { get; set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();

            StudentData = new StudentIndexData();

            StudentData.Students = await _context.
                .Include(i => i.OfficeAssignment)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Department)
                .OrderBy(i => i.LastName)
                .ToListAsync();
        }
    }
}
