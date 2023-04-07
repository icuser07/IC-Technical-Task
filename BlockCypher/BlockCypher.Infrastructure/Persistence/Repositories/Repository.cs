using BlockCypher.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlockCypherDbContext _dbContext;
        private readonly DbSet<T> _dbSet;


        protected Repository(BlockCypherDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> match)
        {
            await Task.CompletedTask;
            return _dbSet.Where(match);
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task<T> InsertAsync(T entity)
        {
            _dbSet.Add(entity);
            await Task.CompletedTask;
            return entity;
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}