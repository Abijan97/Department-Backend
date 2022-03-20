using Department_Backend.Persistence;
using System.Threading.Tasks;

namespace MYNDi.VP.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly APPDBContext context;
        public UnitOfWork(APPDBContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}