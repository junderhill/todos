using Todos.Core.QueryHandlers;
using Todos.Core.RepositoryContracts;
using FakeItEasy;
using Xunit;
using System.Threading;

namespace Todos.Core.Tests
{
    public class ListAllTodoListItemsQueryHandlerTests 
    {
        [Fact]
        public async System.Threading.Tasks.Task TestThatACallToTheReadRepositoryIsMadeAsync()
        {
            //Given
            var mockReadRepo = A.Fake<ITodoReadRepository>();
            var sut = new ListAllTodoItemsQueryHandler(mockReadRepo);
            //When
            await sut.Handle(new Queries.ListAllTodoItemsQuery(), CancellationToken.None);
            //Then
            A.CallTo(() => mockReadRepo.GetTodos()).MustHaveHappened();
        }
    }
}