using BlockCypher.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Commands
{
    public class CreateBlockchainInfoCommand : IRequest<BlockchainInfoResponse>
    {
        public string BlockchainName { get; private set; }

        public CreateBlockchainInfoCommand(string blockchainName)
        {
            this.BlockchainName = blockchainName;
        }
    }
}