using DAL;
using DomainClasses;
using ServiceContracts.UoW;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TipsetDbContext _tipsetDbContext;
        private readonly IDbContextFactory _dbContextFactory;
        
        public UnitOfWork(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
            _tipsetDbContext = _dbContextFactory.GetContext() as TipsetDbContext;
            _tipsetDbContext.Configuration.LazyLoadingEnabled = true;
        }

        public IRepository<Bet> Bets { get { return new Repository<Bet>(_tipsetDbContext); }}

        public void Commit()
        {
            _tipsetDbContext.SaveChanges();
        }

        public IRepository<User> Users { get { return new Repository<User>(_tipsetDbContext); } }
        public IRepository<Match> Matches { get { return new Repository<Match>(_tipsetDbContext); }  }
    }
}
