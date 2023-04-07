using BlockCypher.Application.Commands;
using BlockCypher.Application.DTOs;
using BlockCypher.Application.Mapper;
using BlockCypher.Domain.Entities;
using BlockCypher.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Handlers.CommandHandlers
{
    public class CreateBlockchainInfoHandler : IRequestHandler<CreateBlockchainInfoCommand, BlockchainInfoResponse>
    {
        private readonly IBlockCypherClient _blockCypherClient;
        private readonly IBlockchainRepository _blockchainRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBlockchainInfoHandler(IBlockCypherClient blockCypherClient,
                                           IBlockchainRepository blockchainRepository,
                                           IUnitOfWork unitOfWork)
        {
            if (blockCypherClient == null)
                throw new ArgumentNullException(nameof(blockCypherClient));

            if (blockchainRepository == null)
                throw new ArgumentNullException(nameof(blockchainRepository));

            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));

            _blockCypherClient = blockCypherClient;
            _blockchainRepository = blockchainRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BlockchainInfoResponse> Handle(CreateBlockchainInfoCommand request, CancellationToken cancellationToken)
        {
            string url = $"https://api.blockcypher.com/v1/{request.BlockchainName}/main";

            var response = await _blockCypherClient.GetResource<BlockchainInfoResponse>(url);

            var blochchain = BlockchainInfoMapper.Mapper.Map<Blockchain>(response);

            await _blockchainRepository.InsertAsync(blochchain);
            await _unitOfWork.CommitAsync();

            return response;
        }
    }
}