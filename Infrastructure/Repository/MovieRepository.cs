using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id=1,Name="passion of christ",Cost=2},
            new Movie{Id=2,Name="Home Alone 4",Cost=1}
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
