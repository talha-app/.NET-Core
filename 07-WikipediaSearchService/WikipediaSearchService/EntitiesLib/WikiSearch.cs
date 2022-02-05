﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WikipediaSearchService.EntitiesLib
{
    public partial class WikiSearch
    {
        public WikiSearch()
        {
            Geonames = new HashSet<Geoname>();
        }

        public int Id { get; set; }
        public string Q { get; set; }
        public DateTime SearchTime { get; set; }

        public virtual ICollection<Geoname> Geonames { get; set; }
    }
}
