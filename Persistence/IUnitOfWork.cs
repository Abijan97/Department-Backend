using System.Threading.Tasks;

namespace MYNDi.VP.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}