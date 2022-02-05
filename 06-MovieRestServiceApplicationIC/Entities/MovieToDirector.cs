using System;
using System.Collections.Generic;

#nullable disable

namespace MovieRestServiceApplication.Data
{
    public partial class MovieToDirector
    {
        public long Id { get; set; }
        public long MovieId { get; set; }
        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
