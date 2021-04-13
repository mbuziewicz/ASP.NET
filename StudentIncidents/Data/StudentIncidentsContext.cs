using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;

namespace StudentIncidents.Data
{
    public class StudentIncidentsContext : DbContext
    {
        public StudentIncidentsContext (DbContextOptions<StudentIncidentsContext> options)
            : base(options)
        {
        }

        public DbSet<StudentIncidents.Models.Incident> Incident { get; set; }

        public DbSet<StudentIncidents.Models.Parent> Parent { get; set; }

        public DbSet<StudentIncidents.Models.Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable(nameof(Student))
                .HasMany(c => c.Incidents);
        }

    }
}
