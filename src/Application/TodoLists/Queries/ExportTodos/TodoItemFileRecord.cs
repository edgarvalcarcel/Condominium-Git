using Condominium.Application.Common.Mappings;
using Condominium.Domain.Entities;

namespace Condominium.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}