using System.Threading.Tasks;

namespace ContactsApp.Domain.Events
{
    public interface IDomainCommandHandler<in T>
        where T : IDomainCommand
    {
        Task Handle(T command);
    }
}