using BlockCypher.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Queries
{
    public class GetBlockchainInfoHistoryByNameQuery : IRequest<List<Blockchain>>
    {
        public string Name { get; private set; }

        public GetBlockchainInfoHistoryByNameQuery(string name)
        {
            this.Name = name;
        }
    }
}