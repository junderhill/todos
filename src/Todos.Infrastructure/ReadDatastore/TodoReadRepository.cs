using System.Collections.Generic;
using System.Threading.Tasks;
using Todos.Core.Domain;
using Todos.Core.RepositoryContracts;

namespace Todos.Infrastructure.ReadDatastore
{
    public class TodoReadRepository : ITodoReadRepository
    {
        public Task<IEnumerable<TodoListItem>> GetTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}