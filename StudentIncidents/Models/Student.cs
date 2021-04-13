using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public ICollection<Incident> Incidents { get; set; }


    }
}
