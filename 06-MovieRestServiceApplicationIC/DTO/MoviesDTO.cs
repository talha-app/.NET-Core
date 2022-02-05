using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestServiceApplication.DTO
{
    public partial class MoviesDTO
    {
        public string Name { get; set; }
        public DateTime SceneDate { get; set; }
        public float? Imdb { get; set; }
        public decimal Cost { get; set; }
    }
}
