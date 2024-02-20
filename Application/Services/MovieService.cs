using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        // constructor dependency injection
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
