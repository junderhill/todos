using System.Collections.Generic;
using System.Threading.Tasks;
using Todos.Core.Domain;

namespace Todos.Core.RepositoryContracts
{
    public interface ITodoReadRepository
    {
        Task<IEnumerable<TodoListItem>> GetTodos();
    }
}
