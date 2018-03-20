using System;

namespace ContactsApp.Domain.Events
{
    public class PhotoChanged : IDomainEvent
    {
        public PhotoChanged(Guid id)
        {
            CustomInfoId = id;
        }
        public Guid CustomInfoId { get; }
    }
}