using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MovieRestServiceApplication.Data
{
    public partial class Director
    {
        public Director()
        {
            MovieToDirectors = new HashSet<MovieToDirector>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        
        [NotMapped]
        public virtual ICollection<MovieToDirector> MovieToDirectors { get; set; }
    }
}
