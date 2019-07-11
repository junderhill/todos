using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Todos.Core.Domain;
using Todos.Core.Queries;
using Todos.Core.RepositoryContracts;

namespace Todos.Core.QueryHandlers
{
    public class ListAllTodoItemsQueryHandler : IRequestHandler<ListAllTodoItemsQuery, IEnumerable<TodoListItem>>
    {
        private ITodoReadRepository todoReadRepository;

        public ListAllTodoItemsQueryHandler(ITodoReadRepository readRepository)
        {
            this.todoReadRepository = readRepository;
        }

        public async Task<IEnumerable<TodoListItem>> Handle(ListAllTodoItemsQuery request, CancellationToken cancellationToken)
        {
            return await this.todoReadRepository.GetTodos();
        }
    }
}