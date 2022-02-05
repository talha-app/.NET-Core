using System.Collections.Generic;
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

        public TodoInfo SaveTodoInfo(TodoInfo todoInfo)
        {
            return m_todoAppDAL.SaveTodoInfo(todoInfo);
        }

        public long Count()
        {
            return m_todoAppDAL.Count();
        }

        public IEnumerable<TodoInfo> FindAllTodos()
        {
            return m_todoAppDAL.findAllTodos();
        }
    }
}
