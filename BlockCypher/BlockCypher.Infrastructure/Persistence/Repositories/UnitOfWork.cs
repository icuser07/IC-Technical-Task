using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockCypher.Domain.Interfaces;


namespace BlockCypher.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlockCypherDbContext _dbContext;

        public UnitOfWork(BlockCypherDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.Commit();
        }

        public async Task<int> CommitAsync()
        {
           return  await _dbContext.CommitAsync();
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.CommitAsync(cancellationToken);
        }
    }
}