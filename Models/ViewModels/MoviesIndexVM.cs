using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models.ViewModels
{
    public class MoviesIndexVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public int? Year { get; set; }
        public string Genre { get; set; }
        public bool? HasSeen { get; set; }
        public bool? IsFovourite { get; set; }
    }
}
