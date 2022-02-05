using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WikipediaSearchService.ServiceLib;

namespace WikipediaSearchService.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class WikiSearchController : ControllerBase
    {
        private readonly WikiSearchService wikiSearchService;

        public WikiSearchController(WikiSearchService wikiSearchService)
        {
            this.wikiSearchService = wikiSearchService;
        }

        [HttpGet("place")]
        public async Task<IActionResult> FindPlaceInfo(string place, int maxRows)
        {
            var response = await wikiSearchService.FindGeonames(place, maxRows);
            return new ObjectResult(response);
        }

    }
}
