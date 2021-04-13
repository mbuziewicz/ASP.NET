using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public int NumberOfStars { get; set; }
        public string ReviewText { get; set; }
        public string ImageURL { get; set; }
    }
}
