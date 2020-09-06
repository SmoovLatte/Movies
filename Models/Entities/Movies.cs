using System;
using System.Collections.Generic;

namespace Movies.Models.Entities
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public int? Year { get; set; }
        public string Genre { get; set; }
        public bool? HasSeen { get; set; }
        public bool? IsFovourite { get; set; }
    }
}
