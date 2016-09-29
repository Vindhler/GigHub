using System;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(128)]
        public string Name { get; set; }
    }
}