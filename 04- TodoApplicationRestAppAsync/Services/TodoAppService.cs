
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApplication.DAL;
using TodoApplication.Dto;
using TodoApplication.Entities;
using TodoApplication.Mapper;

namespace TodoApplication.Services
{
    public class TodoAppService
    {
        private readonly TodoAppDAL m_todoAppDAL;
        private readonly Mapper.MapsterMapper m_mapper;

        public TodoAppService(TodoAppDAL todoAppDAL, Mapper.MapsterMapper mapper)
        {
            m_todoAppDAL = todoAppDAL;
            m_mapper = mapper;
        }

        public async Task<TodoInfo> SaveTodoInfo(TodoInfo todoInfo)
        {
            return await m_todoAppDAL.SaveTodoInfoAsync(todoInfo);
        }

        public async Task<long> Count()
        {
            return await m_todoAppDAL.CountAsync();
        }

        public IEnumerable<TodoInfoDTO> FindAllTodos()
        {
            var todos = m_todoAppDAL.FindAllTodosAsync().Result;

            var todosDTOList = new List<TodoInfoDTO>();

            foreach (var todo in todos)
            {
                var todoDTO = m_mapper.Map<TodoInfo, TodoInfoDTO>(todo);
                todosDTOList.Add(todoDTO);
            }

            return todosDTOList;

        }
    }
}
