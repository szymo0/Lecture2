using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Lecture2.Infrastucture
{
    public class AutofacContainer
    {
        public static IContainer GetContainer()
        {
            Autofac.ContainerBuilder containerBuilder=new ContainerBuilder();
            containerBuilder.RegisterAssemblyModules(typeof(IBindable<>).Assembly);
            return containerBuilder.Build();
        }
    }
}
