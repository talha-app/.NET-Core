using MovieRestServiceApplication.DAL;
using MovieRestServiceApplication.Data;
using MovieRestServiceApplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.Service
{
    public class MoviesService
    {
        private readonly MoviesDataHelper moviesDataHelper;

        public MoviesService(MoviesDataHelper moviesDataHelper)
        {
            this.moviesDataHelper = moviesDataHelper;
        }

        public Task<long> CountMovieAsync()
        {
            return moviesDataHelper.CountMovieAsync();
        }

        public IEnumerable<MoviesDTO> FindAllMovies()
        {
            return moviesDataHelper
                .FindAllMoviesAsync()
                .Result
                .Select(m => new MoviesDTO { Name = m.Name, Cost = m.Cost, Imdb = m.Imdb, SceneDate = m.SceneDate }).ToList();
        }

        public async Task<IEnumerable<MoviesDTO>> FindMoviesByYearAsync(int year)
        {
            var moviesFilteredByYear = await moviesDataHelper.FindMoviesByYearAsync(year);
            return moviesFilteredByYear.Select(m => new MoviesDTO { Name = m.Name, Cost = m.Cost, Imdb = m.Imdb, SceneDate = m.SceneDate }).ToList();
        }

        public async Task<IEnumerable<MoviesDTO>> FindMoviesByYearAndMonthAsync(int year, int month)
        {
            var moviesFiltered = await moviesDataHelper.FindMoviesByYearAndMonthAsync(year, month);

            return moviesFiltered.Select(m => new MoviesDTO { Name = m.Name, Cost = m.Cost, Imdb = m.Imdb, SceneDate = m.SceneDate }).ToList();
        }

        public Movie SaveMovieAsync(Movie entity)
        {
            return moviesDataHelper.SaveMovieAsync(entity).Result;
        }

        public IEnumerable<Movie> FindMoviesByDirectorIdAsync(int id)
        {
            return moviesDataHelper.FindMoviesByDirectorIdAsync(id).Result;
        }
    }
}
