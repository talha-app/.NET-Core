using Microsoft.AspNetCore.Mvc;
using TodoApplication.Entities;
using TodoApplication.Services;

namespace TodoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoAppService m_todoAppService;

        public TodoController(TodoAppService todoAppService)
        {
            m_todoAppService = todoAppService;
        }

        [HttpPost("save")]
        public IActionResult Save([FromBody]TodoInfo todoInfo)
        {
            try
            {
                return new ObjectResult(m_todoAppService.SaveTodoInfo(todoInfo));
            }
            catch
            {
                return NoContent();
            }

        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            try
            {
                return new ObjectResult(m_todoAppService.Count());
            }
            catch
            {
                return NoContent();
            }
        }


        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return new ObjectResult(m_todoAppService.FindAllTodos());
            }
            catch
            {
                return NoContent();
            }
        }


    }
}
