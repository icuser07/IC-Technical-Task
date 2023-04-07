using BlockCypher.Application.Queries;
using BlockCypher.Domain.Entities;
using BlockCypher.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Handlers.QueryHandlers
{
    public class GetBlockchainInfoHistoryByNameHandler : IRequestHandler<GetBlockchainInfoHistoryByNameQuery, List<Blockchain>>
    {
        private readonly IBlockchainRepository _blockchainRepository;

        public GetBlockchainInfoHistoryByNameHandler(IBlockchainRepository blockchainRepository)
        {
            if (blockchainRepository == null)
                throw new ArgumentNullException(nameof(blockchainRepository));

            _blockchainRepository = blockchainRepository;
        }

        public async Task<List<Blockchain>> Handle(GetBlockchainInfoHistoryByNameQuery request, CancellationToken cancellationToken)
        {
            var blockchainHistory = (await _blockchainRepository.FindAsync(b => b.Name.Equals(request.Name)))
                .OrderByDescending(b => b.CreatedAt)
                .ToList();

            return blockchainHistory;
        }
    }
}