using Autofac;
using ContactsApp.Domain.Commands;
using ContactsApp.Domain.Events;
using ContactsApp.Domain.Repositories;

namespace Lecture2.Infrastucture
{
    public class AutofacModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ContactInfoRepository).Assembly).AsClosedTypesOf(typeof(IDomainCommandHandler<>)).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(ContactInfoRepository).Assembly).AsClosedTypesOf(typeof(IDomainEventHandler<>)).AsImplementedInterfaces();
            builder.RegisterType<ContactInfoRepository>().AsImplementedInterfaces();
            builder.RegisterType<Dispatchers>().AsImplementedInterfaces();
        }
    }
}
