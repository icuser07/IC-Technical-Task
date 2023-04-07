using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Domain.Interfaces
{
    public interface IBlockCypherClient
    {
        Task<T> GetResource<T>(string url);
    }
}