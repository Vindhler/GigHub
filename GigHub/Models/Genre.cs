using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Genre
    {
        [Required]
        public Byte Id { get; set; }
        [Required]
        public string GenreName { get; set; }
    }
}