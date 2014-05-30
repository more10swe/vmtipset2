using DAL;
using DomainClasses;
using ServiceContracts.DomainClasses.Interfaces;
using ServiceContracts.UoW;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private TipsetDbContext DbContext { get; set; }

        public UnitOfWork()
        {
            DbContext = new TipsetDbContext();
            DbContext.Configuration.LazyLoadingEnabled = true;
        }

        public IRepository<Bet> Bets { get { return; } }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public IRepository<User> Users { get { return DbContext.Users; } }
        public IRepository<Match> Matches { get { return; }  }
    }
}
