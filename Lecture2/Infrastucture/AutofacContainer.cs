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
