using System.Collections.Generic;
using System.Threading.Tasks;
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

        public IEnumerable<TodoInfo> FindAllTodos()
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

        public Task<IEnumerable<TodoInfo>> FindAllTodosAsync()
        {
            var task = new Task<IEnumerable<TodoInfo>>(() => FindAllTodos());
            task.Start();
            return task;
        }

        public Task<long> CountAsync()
        {
            var task = new Task<long>(() => Count());
            task.Start();
            return task;
        }

        public Task<TodoInfo> SaveTodoInfoAsync(TodoInfo todoInfo)
        {
            var task = new Task<TodoInfo>(() => SaveTodoInfo(todoInfo));
            task.Start();
            return task;
        }


    }
}
