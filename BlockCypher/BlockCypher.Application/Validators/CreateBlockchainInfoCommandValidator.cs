using BlockCypher.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Validators
{
    internal class CreateBlockchainInfoCommandValidator : AbstractValidator<CreateBlockchainInfoCommand>
    { 
        public CreateBlockchainInfoCommandValidator()
        {
            var validBlockchainNames = new List<string>() { "eth", "dash", "btc" };

            RuleFor(x => x.BlockchainName).NotEmpty();
            RuleFor(x => x.BlockchainName)
                .Must(x => validBlockchainNames.Contains(x))
                .WithMessage("Please use valid blockchain name: " + string.Join(", ", validBlockchainNames));
        }
    }
}