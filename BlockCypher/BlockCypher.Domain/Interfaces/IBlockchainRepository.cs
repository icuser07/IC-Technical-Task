using BlockCypher.Domain.Base;
using BlockCypher.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Domain.Interfaces
{
    public interface IBlockchainRepository : IRepository<Blockchain>
    {

    }
}