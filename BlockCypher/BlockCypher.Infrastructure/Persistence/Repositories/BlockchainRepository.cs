using BlockCypher.Domain.Entities;
using BlockCypher.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Infrastructure.Persistence.Repositories
{
    public class BlockchainRepository : Repository<Blockchain>, IBlockchainRepository
    {
        public BlockchainRepository(BlockCypherDbContext dbContext) : base(dbContext) 
        { 
            
        }
    }
}