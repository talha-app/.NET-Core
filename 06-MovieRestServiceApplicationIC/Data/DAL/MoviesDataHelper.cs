using MovieRestServiceApplication.Data;
using MovieRestServiceApplication.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.DAL
{
    public class MoviesDataHelper
    {
        private readonly MovieRepository movieRepository;
        private readonly DirectorRepository directorRepository;

        public MoviesDataHelper(MovieRepository movieRepository, DirectorRepository directorRepository)
        {
            this.movieRepository = movieRepository;
            this.directorRepository = directorRepository;
        }

        public Task<long> CountMovieAsync()
        {
            return movieRepository.CountAsync();
        }

        public Task<IEnumerable<Movie>> FindAllMoviesAsync()
        {
            return movieRepository.FindAllAsync();
        }

        public Task<IEnumerable<Movie>> FindMoviesByYearAsync(int year)
        {
            return movieRepository.FindByYearAsync(year);
        }

        public Task<IEnumerable<Movie>> FindMoviesByYearAndMonthAsync(int year, int month)
        {
            return movieRepository.FindByYearAndMonthAsync(year, month);
        }

        public Task<Movie> SaveMovieAsync(Movie entity)
        {
            return movieRepository.SaveAsync(entity);
        }

        public Task<IEnumerable<Movie>> FindMoviesByDirectorIdAsync(int id)
        {
            return movieRepository.FindByDirectorIdAsync(id);
        }

        public Task<long> CountDirectorsAsync()
        {
            return directorRepository.CountAsync();
        }

        public Task<Director> SaveDirectorAsync(Director entity)
        {
            return directorRepository.SaveAsync(entity);
        }
    }
}
