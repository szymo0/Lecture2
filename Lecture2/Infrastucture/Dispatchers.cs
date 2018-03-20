using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ContactsApp.Domain.Commands;
using ContactsApp.Domain.Events;

namespace Lecture2.Infrastucture
{
    public class Dispatchers : IEventDomainDispatcher, ICommandDomainDispatcher
    {
        protected static IContainer Container = AutofacContainer.GetContainer();
        public static void Rise<TEvent>(TEvent @event)
            where TEvent : IDomainEvent
        {
            var eventHandler = Container.Resolve<IEnumerable<IDomainEventHandler<TEvent>>>();
            List<Task> tasks = new List<Task>();
            foreach (var domainEventHandler in eventHandler)
            {
                tasks.Add(domainEventHandler.Handle(@event));

            }

            Task.WaitAll(tasks.ToArray());
        }

        public static async Task RiseCommand<TCommand>(TCommand command)
            where TCommand : IDomainCommand
        {
            var commandHandler = Container.Resolve<IDomainCommandHandler<TCommand>>();
            await commandHandler.Handle(command);
        }

        void IEventDomainDispatcher.Dispatch<TEvent>(TEvent eventToDispatch)
        {
            Rise(eventToDispatch);
        }

        async void ICommandDomainDispatcher.Dispatch<TCommand>(TCommand command)
        {
            await RiseCommand(command);
        }
    }
}
