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
    public class DirectorsController : ControllerBase
    {
        private readonly DirectorsService directorsService;

        public DirectorsController(DirectorsService directorsService)
        {
            this.directorsService = directorsService;
        }

        [HttpGet("count")]
        public IActionResult CountDirectors()
        {
            return new ObjectResult(directorsService.CountDirectorsAsync());
        }

        [HttpPost]
        public IActionResult SaveDirector(Director director)
        {
            return new ObjectResult(directorsService.SaveDirectorAsync(director));
        }


    }
}
