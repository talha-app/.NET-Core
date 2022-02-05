using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WikipediaSearchService.DTO;

namespace WikipediaSearchService.ServiceLib
{
    public class WikiSearchService
    {
        public const string WikiUrlTemplate = "http://api.geonames.org/wikipediaSearchJSON?q={0}&maxRows={1}&username=csystem";

        private readonly HttpClient m_httpClient;

        public WikiSearchService(HttpClient httpClient)
        {
            m_httpClient = httpClient;
        }

        public async Task<IEnumerable<Geoname>> FindGeonames(string q, int maxRows)
        {
            var response = await m_httpClient.GetAsync(string.Format(WikiUrlTemplate, q, maxRows));
            var responseJsonStr = await response.Content.ReadAsStringAsync();
            var wiki = JsonConvert.DeserializeObject<WikiSearchInfo>(responseJsonStr);
            return wiki.Geonames;
        }

    }
}
