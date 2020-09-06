using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models.Entities;
using Movies.Models.ViewModels;


namespace Movies.Models
{
    public class MoviesService
    {
        MyContext context;

        public MoviesService(MyContext context)
        {
            this.context = context;
        }
        //// Our "poor mans" DB

        //private static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie {Title = "Notebook", Description = "blabla", Genre="romantic drama", HasSeen = true, IsFovourite = true, Year = 2008, Length = 115, Id = 0},
        //    new Movie {Title = "Ghostbusters", Description = "who you gonna call", Genre="comedy", HasSeen = true, IsFovourite = false, Year = 1998, Length = 105, Id = 1}
        //};

        public MoviesIndexVM[] GetAllMovies()
        {
            // call the deserilization method here if DB is empty
            return context.Movies.OrderBy(m => m.Title).Select(m => new MoviesIndexVM
            {
                Title = m.Title, Description = m.Description,
                Length = m.Length, Genre = m.Genre, HasSeen = m.HasSeen,
                IsFovourite = m.IsFovourite, Year = m.Year

            }).ToArray();

        }

        public void Create(MoviesCreateVM m)
        {
            context.Movies.Add(new Entities.Movies
            {
                Title = m.Title,
                Description = m.Description,
                Length = m.Length,
                Genre = m.Genre,
                HasSeen = m.HasSeen,
                IsFovourite = m.IsFovourite,
                Year = m.Year
            });
            context.SaveChanges();
        }
    }
}
