using Astra.Core.Entities;
using Astra.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Astra.API.Infrastructure
{
    public class ApiDbContext : MainDbContext
    {
        public ApiDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}