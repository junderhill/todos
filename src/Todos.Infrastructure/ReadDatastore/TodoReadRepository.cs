using System.Collections.Generic;
using System.Threading.Tasks;
using Todos.Core.Domain;
using Todos.Core.RepositoryContracts;
using Npgsql;

namespace Todos.Infrastructure.ReadDatastore
{
    public class TodoReadRepository : ITodoReadRepository
    {
        private readonly Npgsql.NpgsqlConnection connection;
        public TodoReadRepository()
        {
            //todo: where to get the db connection from? inject? factory?            
        }

        public Task<IEnumerable<TodoListItem>> GetTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}