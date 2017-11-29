using Astra.Core.Interfaces;
using Astra.EntityFramework;
using Astra.ToDo.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astra.ToDo.Data
{
    public class ToDoDbContext : MainDbContext
    {
        public ToDoDbContext() : base("ToDoDbConnection") { }

        public ToDoDbContext(string nameOrConnectionString, IDomainEventDispatcher dispatcher) : base(nameOrConnectionString, dispatcher) { }

        public DbSet<ToDoItem> ToDoItems { get { return Set<ToDoItem>(); } }
    }
}
