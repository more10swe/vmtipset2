using System.Data.Entity;
using System.Linq;

namespace ServiceContracts.UoW
{
    public interface IDbContextFactory
    {
        DbContext GetContext();
    }
}