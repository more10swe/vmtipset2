using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ServiceContracts.UoW;

namespace UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        public DbContext DbContext { get { return _dbContext ?? new TipsetDbContext(); } }
        internal DbSet<T> DbSet;
        //public Repository()
        //    : this(new TipsetDbContext()) { }

        public Repository(DbContext context = null)
        {
            _dbContext = context;
            DbSet = DbContext.Set<T>();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
    }
}
