using Astra.Core.Entities;
using Astra.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Astra.API.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiDbContext : MainDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public ApiDbContext() : base("DefaultConnection")
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}