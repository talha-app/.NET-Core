using MovieRestServiceApplication.DAL;
using MovieRestServiceApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.Service
{
    public class DirectorsService
    {
        private readonly MoviesDataHelper moviesDataHelper;

        public DirectorsService(MoviesDataHelper moviesDataHelper)
        {
            this.moviesDataHelper = moviesDataHelper;
        }

        public long CountDirectorsAsync()
        {
            return moviesDataHelper.CountDirectorsAsync().Result;
        }

        public Director SaveDirectorAsync(Director entity)
        {
            return moviesDataHelper.SaveDirectorAsync(entity).Result;
        }

    }
}
