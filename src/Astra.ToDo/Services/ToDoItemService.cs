using System;
using Astra.Core.Interfaces;
using Astra.ToDo.Data;
using Astra.ToDo.Domain;
using Astra.ToDo.Events;

namespace Astra.ToDo.Services
{
    public class ToDoItemService : IHandle<ToDoItemSavedEvent>
    {
        private readonly ToDoDbContext _context;

        public ToDoItemService(ToDo.Data.ToDoDbContext context)
        {
            _context = context;
        }

        public void Handle(ToDoItemSavedEvent domainEvent)
        {
            // Do Nothing
            
        }

        public void CreateToDo(ToDoItem toDoItem)
        {
            _context.Set<ToDoItem>().Add(toDoItem);
            _context.SaveChanges();
        }
    }
}
