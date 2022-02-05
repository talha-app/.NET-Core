using System.Collections.Generic;
using TodoApplication.Entities;

namespace TodoApplication.Repositories
{
    public interface ITodoRepository : ICrudRepository<TodoInfo, int>
    {
        IEnumerable<TodoInfo> FindByMonth(int month);
    }
}
