using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ContactsApp.Domain.Events;
using ContactsApp.Domain.Repositories;

namespace Lecture2.Infrastucture
{
    public class AutofacModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(ThisAssembly, typeof(ContactInfoRepository).Assembly)
                .AsClosedTypesOf(typeof(IDomainCommandHandler<>)).AsImplementedInterfaces()
                .AsClosedTypesOf(typeof(IDomainEventHandler<>)).AsImplementedInterfaces();
            builder.RegisterType<ContactInfoRepository>().AsImplementedInterfaces();
        }
    }
}
