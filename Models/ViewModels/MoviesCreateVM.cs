using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models.ViewModels
{
    public class MoviesCreateVM
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Enter title")]
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }

        [Display(Name = "Year")]
        public int? Year { get; set; }
        public string Genre { get; set; }
        public bool? HasSeen { get; set; }
        public bool? IsFovourite { get; set; }
    }
}
