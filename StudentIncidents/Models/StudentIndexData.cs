using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class StudentIndexData
    {
        public IEnumerable<Parent> Parents { get; set; }
        public IEnumerable<Incident> Incidents { get; set; }
    }
}
