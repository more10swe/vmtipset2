using System.Data.Entity;
using DAL;
using ServiceContracts.UoW;

namespace UnitOfWork
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly TipsetDbContext _tipsetDbContext;

        public DbContextFactory()
        {
            _tipsetDbContext = new TipsetDbContext();
        }
        public DbContext GetContext()
        {
            return _tipsetDbContext;
        }
    }
}
