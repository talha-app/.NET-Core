using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MovieRestServiceApplication.Data
{
    public partial class Movie
    {
        public Movie()
        {
            MovieToDirectors = new HashSet<MovieToDirector>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime SceneDate { get; set; }
        public long? Rating { get; set; }
        public float? Imdb { get; set; }
        public decimal Cost { get; set; }

        [NotMapped]
        public virtual ICollection<MovieToDirector> MovieToDirectors { get; set; }
    }
}
