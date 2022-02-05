using MovieRestServiceApplication.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.Repositories
{
    public class MovieRepository
    {
        private readonly MovieAppDbContext movieAppDbContext;

        public MovieRepository(MovieAppDbContext movieAppDbContext)
        {
            this.movieAppDbContext = movieAppDbContext;
        }

        public Task<long> CountAsync()
        {
            var task = new Task<long>(() => Count());
            task.Start();
            return task;
        }

        public Task<IEnumerable<Movie>> FindAllAsync()
        {
            var task = new Task<IEnumerable<Movie>>(() => FindAll());
            task.Start();
            return task;
        }

        public Task<IEnumerable<Movie>> FindByYearAsync(int year)
        {
            var task = new Task<IEnumerable<Movie>>(() => FindByYear(year));
            task.Start();
            return task;
        }

        public Task<IEnumerable<Movie>> FindByYearAndMonthAsync(int year, int month)
        {
            var task = new Task<IEnumerable<Movie>>(() => FindByYearAndMonth(year, month));
            task.Start();
            return task;
        }
        public Movie Save(Movie entity)
        {
            movieAppDbContext.Add(entity);
            if (movieAppDbContext.SaveChanges() != 1)
            {
                throw new Exception("Internal Db Problem");
            }
            return entity;
        }

        public Task<Movie> SaveAsync(Movie entity)
        {
            var task = new Task<Movie>(() => Save(entity));
            task.Start();
            return task;
        }

        public Task<IEnumerable<Movie>> FindByDirectorIdAsync(int id)
        {
            var task = new Task<IEnumerable<Movie>>(() => FindByDirectorId(id));
            task.Start();
            return task;
        }

        private IEnumerable<Movie> FindByDirectorId(int id)
        {
            return from mtd in movieAppDbContext.MovieToDirectors
                   join m in movieAppDbContext.Movies on mtd.MovieId equals m.Id
                   where mtd.DirectorId == id
                   select m;
        }

        public long Count()
        {
            return movieAppDbContext.Movies.LongCount();
        }

        public IEnumerable<Movie> FindAll()
        {
            return movieAppDbContext.Movies.ToList();
        }

        public IEnumerable<Movie> FindByYear(int year)
        {
            return movieAppDbContext.Movies.Where(m => m.SceneDate.Year == year).ToList();
        }

        public IEnumerable<Movie> FindByYearAndMonth(int year, int month)
        {
            return movieAppDbContext.Movies.Where(m => m.SceneDate.Year == year && m.SceneDate.Month == month).ToList();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(IEnumerable<Movie> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllAsync(IEnumerable<Movie> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllById(IEnumerable<long> ids)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllByIdAsync(IEnumerable<long> ids)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public bool ExistsById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(long id)
        {
            throw new NotImplementedException();
        }



        public Movie FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> FindByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Movie> SaveAll(IEnumerable<Movie> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> SaveAllAsync(IEnumerable<Movie> entities)
        {
            throw new NotImplementedException();
        }


    }
}
