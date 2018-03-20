using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ContactsApp.Domain.Events;

namespace Lecture2.Infrastucture
{
    public class Dispatchers : IEventDomainDispatcher, ICommandDomainDispatcher
    {
        protected static IContainer Container = AutofacContainer.GetContainer();
        public static Task Rise<TEvent>(TEvent @event)
            where TEvent : IDomainEvent
        {
            var eventHandler = Container.Resolve<IEnumerable<IDomainEventHandler<TEvent>>>();
            foreach (var domainEventHandler in eventHandler)
            {
                domainEventHandler.Handle(@event);

            }
            return Task.CompletedTask;
        }

        public static Task RiseCommand<TCommand>(TCommand command)
            where TCommand : IDomainCommand
        {
            var commandHandler = Container.Resolve<IDomainCommandHandler<TCommand>>();
            commandHandler.Handle(command);
            return Task.CompletedTask;
        }
        void IEventDomainDispatcher.Dispatch<TEvent>(TEvent eventToDispatch)
        {
            Rise(eventToDispatch);
        }

        void ICommandDomainDispatcher.Dispatch<TCommand>(TCommand command)
        {
            RiseCommand(command);
        }
    }
}
