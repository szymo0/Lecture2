using System;
using System.Threading.Tasks;
using ContactsApp.Domain.ValueObjects;

namespace ContactsApp.Domain.Events
{
    public class PhotoChanged : IDomainEvent
    {
        public PhotoChanged(Guid id, ContactPhoto contactPhoto)
        {
            CustomInfoId = id;
            Photo = contactPhoto;
        }
        public Guid CustomInfoId { get; }
        public ContactPhoto Photo { get; }
    }

    public class ConsoleLogger : IDomainEventHandler<PhotoChanged>
    {
        public Task Handle(PhotoChanged @event)
        {
            return Task.Run(() => Console.WriteLine($"{@event.GetType().FullName} - {@event.CustomInfoId} - {@event.Photo}"));
        }
    }
}