using BlockCypher.Application.Queries;
using BlockCypher.Domain.Common;
using BlockCypher.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using BlockCypher.Domain.Interfaces;

namespace BlockCypher.Application.Handlers.QueryHandlers
{
    public class GetBlockchainInfoByNameHandler : IRequestHandler<GetBlockchainInfoByNameQuery, Blockchain>
    {
        private readonly IBlockchainRepository _blockchainRepository;

        public GetBlockchainInfoByNameHandler(IBlockchainRepository blockchainRepository)
        {
            if(blockchainRepository == null)
                throw new ArgumentNullException(nameof(blockchainRepository));

            _blockchainRepository = blockchainRepository;
        }

        public async Task<Blockchain> Handle(GetBlockchainInfoByNameQuery request, CancellationToken cancellationToken)
        {
            var blockchain = (await _blockchainRepository.FindAsync(b => b.Name.Equals(request.Name)))
                .OrderByDescending(b => b.CreatedAt)
                .FirstOrDefault();

            return blockchain;
                
        }
    }
}