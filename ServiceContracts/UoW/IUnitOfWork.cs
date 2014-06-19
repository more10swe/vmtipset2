using DomainClasses;

namespace ServiceContracts.UoW
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Match> Matches { get; }
        IRepository<Bet> Bets { get; }

        void Commit();

    }
}
