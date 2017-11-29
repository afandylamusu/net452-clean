using Astra.Core;
using Astra.ToDo.Domain;

namespace Astra.ToDo.Events
{
    public class ToDoItemSavedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemSavedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}