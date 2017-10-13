using Astra.Core.Interfaces;
using System.Linq;
using Astra.Core.Entities;
using Astra.Core.SharedKernel;
using System.Data.Entity;

namespace Astra.Infrastructure.Data
{
    public class MainDbContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;

        public MainDbContext(string connectionString, IDomainEventDispatcher dispatcher)
            : base(connectionString)
        {
            _dispatcher = dispatcher;
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        public override int SaveChanges()
        {
            int result = base.SaveChanges();

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.Events.Any())
                .ToArray();

            foreach (var entity in entitiesWithEvents)
            {
                var events = entity.Events.ToArray();
                entity.Events.Clear();
                foreach (var domainEvent in events)
                {
                    _dispatcher.Dispatch(domainEvent);
                }
            }

            return result;
        }
    }
}