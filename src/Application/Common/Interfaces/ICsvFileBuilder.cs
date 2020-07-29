using Condominium.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Condominium.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}