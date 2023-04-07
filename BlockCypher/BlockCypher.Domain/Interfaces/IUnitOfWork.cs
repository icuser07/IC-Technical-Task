using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync();
        Task<int> CommitAsync(CancellationToken cancellationToken = default);
    }
}