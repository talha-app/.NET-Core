using Microsoft.AspNetCore.Mvc;
using MovieRestServiceApplication.Data;
using MovieRestServiceApplication.DTO;
using MovieRestServiceApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesService moviesService;

        public MoviesController(MoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet("find/year")]
        public async Task<IActionResult> FindMoviesByYearAsync(int year)
        {
            return new ObjectResult(await moviesService.FindMoviesByYearAsync(year));
        }

        [HttpGet("find/yearmonth")]
        public async Task<IActionResult> FindMoviesByYearAndMonthAsync(int year, int month)
        {
            return new ObjectResult(await moviesService.FindMoviesByYearAndMonthAsync(year, month));
        }

        [HttpGet("find/directorId")]
        public IActionResult FindMoviesByDirectorId(int directorId)
        {
            return new ObjectResult(moviesService.FindMoviesByDirectorIdAsync(directorId));
        }

        [HttpGet("find/all")]
        public IActionResult FindAll()
        {
            return new ObjectResult(moviesService.FindAllMovies());
        }

        [HttpPost("save/movie")]
        public IActionResult SaveMovie([FromBody] Movie movie)
        {
            return new ObjectResult(moviesService.SaveMovieAsync(movie));
        }
    }
}
