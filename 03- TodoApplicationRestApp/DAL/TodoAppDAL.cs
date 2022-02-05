using System.Collections.Generic;
using TodoApplication.Entities;
using TodoApplication.Repositories;

namespace TodoApplication.DAL
{
    public class TodoAppDAL
    {
        private readonly ITodoRepository todoRepository;

        public TodoAppDAL(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public IEnumerable<TodoInfo> findAllTodos()
        {
            return todoRepository.FindAll();
        }

        public TodoInfo SaveTodoInfo(TodoInfo todoInfo)
        {
            return todoRepository.Save(todoInfo);
        }
        public long Count()
        {
            return todoRepository.Count();
        }
    }
}
