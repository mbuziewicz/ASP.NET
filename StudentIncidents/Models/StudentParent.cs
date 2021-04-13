using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class StudentParent
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int ParentID { get; set; }

    }
}
