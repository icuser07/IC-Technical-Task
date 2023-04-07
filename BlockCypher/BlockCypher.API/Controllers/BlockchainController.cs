using BlockCypher.Application.Commands;
using BlockCypher.Application.Queries;
using BlockCypher.Domain.Common;
using BlockCypher.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlockCypher.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockchainController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlockchainController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        [Route("createInfoRecord")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<ActionResult<Blockchain>> CreateInfoRecord([FromBody] string blockchainName)
        {
            var result = await _mediator.Send(new CreateBlockchainInfoCommand(blockchainName));
            return Ok(result);
        }


        [HttpGet]
        [Route("ETH/Info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<Blockchain> GetETHBlockchainInfo()
        {
            return await _mediator.Send(new GetBlockchainInfoByNameQuery(BlockchainNameConstants.ETH));
        }

        [HttpGet]
        [Route("ETH/Info/All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<List<Blockchain>> GetETHBlockchainInfoHistory()
        {
            return await _mediator.Send(new GetBlockchainInfoHistoryByNameQuery(BlockchainNameConstants.ETH));
        }


        [HttpGet]
        [Route("Dash/Info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<Blockchain> GetDASHBlockchainInfo()
        {
            return await _mediator.Send(new GetBlockchainInfoByNameQuery(BlockchainNameConstants.DASH));
        }

        [HttpGet]
        [Route("Dash/Info/All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<List<Blockchain>> GetDASHBlockchainInfoHistory()
        {
            return await _mediator.Send(new GetBlockchainInfoHistoryByNameQuery(BlockchainNameConstants.DASH));
        }

        [HttpGet]
        [Route("BTC/Info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<Blockchain> GetBTCBlockchainInfo()
        {
            return await _mediator.Send(new GetBlockchainInfoByNameQuery(BlockchainNameConstants.BTC));
        }

        [HttpGet]
        [Route("BTC/Info/All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<List<Blockchain>> GetBTCBlockchainInfoHistory()
        {
            return await _mediator.Send(new GetBlockchainInfoHistoryByNameQuery(BlockchainNameConstants.BTC));
        }

    }
}