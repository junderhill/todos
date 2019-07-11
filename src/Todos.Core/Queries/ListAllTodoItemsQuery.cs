using System.Collections.Generic;
using MediatR;
using Todos.Core.Domain;

namespace Todos.Core.Queries
{
    public class ListAllTodoItemsQuery : IRequest<IEnumerable<TodoListItem>>
    {
    }
}