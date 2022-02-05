using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using TodoApplication.Data;
using TodoApplication.Entities;

namespace TodoApplication.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoAppDbContext dbContext;

        public TodoRepository(TodoAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IEnumerable<TodoInfo> FindAll()
        {
            return dbContext.TodoInfos.ToList();

        }
        public TodoInfo Save(TodoInfo todoInfo)
        {
            dbContext.TodoInfos.Add(todoInfo);
            dbContext.SaveChanges();
            return todoInfo;
        }

        public long Count()
        {
            return dbContext.TodoInfos.LongCount();
        }

        public IEnumerable<TodoInfo> SaveAll(IEnumerable<TodoInfo> entities)
        {
            dbContext.TodoInfos.AddRange(entities);
            dbContext.SaveChanges();
            return entities;
        }

        public void Delete(TodoInfo entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(IEnumerable<TodoInfo> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllById(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistsById(int id)
        {
            throw new NotImplementedException();
        }

        public TodoInfo FindById(int id)
        {
            return dbContext.TodoInfos.Where(t => t.Id == id).First();
        }

        public IEnumerable<TodoInfo> FindByMonth(int month)
        {
            throw new NotImplementedException();
        }
    }
}
