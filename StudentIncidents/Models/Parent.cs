using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class Parent
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string ParentFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string ParentLastName { get; set; }
        public string ParentPhone { get; set; }
        public string ParentEmail { get; set; }


    }
}
