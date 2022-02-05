using System.Collections.Generic;
using System.Linq;
using WikipediaSearchService.Data;
using WikipediaSearchService.EntitiesLib;

namespace WikipediaSearchService.RepositoryLib
{
    public class WikisearchRepository
    {
        private readonly WikiSearchAppDbContext wikiSearchAppDbContext;

        public WikisearchRepository(WikiSearchAppDbContext wikiSearchAppDbContext)
        {
            this.wikiSearchAppDbContext = wikiSearchAppDbContext;
        }

        public WikiSearch Save(WikiSearch wikiSearch)
        {
            wikiSearchAppDbContext.WikiSearches.Add(wikiSearch);
            wikiSearchAppDbContext.SaveChanges();
            return wikiSearch;
        }

        public IEnumerable<WikiSearch> FindByQ(string q)
        {
            return wikiSearchAppDbContext.WikiSearches.Where(w => w.Q == q).AsEnumerable();
        }
    }
}
 