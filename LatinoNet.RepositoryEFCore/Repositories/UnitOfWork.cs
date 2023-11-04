using System.Threading.Tasks;
using LatinoNet.Entities.Interfaces;
using LatinoNet.RepositoryEFCore.DataContext;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LatinoNetContext _context;

        public UnitOfWork(LatinoNetContext context)
        {
            _context = context;
        }
        
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}