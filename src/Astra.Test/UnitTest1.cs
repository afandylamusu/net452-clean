using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astra.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TodoService()
        {
            var service = new ToDo.Services.ToDoItemService(new ToDo.Data.ToDoDbContext());
            service.CreateToDo(new ToDo.Domain.ToDoItem {
                Title = "Test Todo",
                _CreatedUtc = DateTime.UtcNow,
                _LastModifiedUtc = DateTime.UtcNow
            });
        }
    }
}
