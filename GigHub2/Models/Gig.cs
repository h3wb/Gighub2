using System;

namespace GigHub2.Models
{
    public class Gig
    {
        public int ID { get; set; }
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }
    }
}