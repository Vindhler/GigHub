using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }
        public Genre Genre { get; set; }

    }
}