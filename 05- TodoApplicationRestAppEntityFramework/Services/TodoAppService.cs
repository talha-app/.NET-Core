
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApplication.DAL;
using TodoApplication.Entities;

namespace TodoApplication.Services
{
    public class TodoAppService
    {
        private readonly TodoAppDAL m_todoAppDAL;

        public TodoAppService(TodoAppDAL todoAppDAL)
        {
            m_todoAppDAL = todoAppDAL;
        }

        public async Task<TodoInfo> SaveTodoInfo(TodoInfo todoInfo)
        {
            return await m_todoAppDAL.SaveTodoInfoAsync(todoInfo);
        }

        public long Count()
        {
            return m_todoAppDAL.CountAsync().Result;
        }

        public IEnumerable<TodoInfo> FindAllTodos()
        {
            var todos = m_todoAppDAL.FindAllTodosAsync().Result;

            return todos;

        }
    }
}
