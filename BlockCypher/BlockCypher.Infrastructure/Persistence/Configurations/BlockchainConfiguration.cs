using BlockCypher.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Infrastructure.Persistence.Configurations
{
    public class BlockchainConfiguration : IEntityTypeConfiguration<Blockchain>
    {
        public void Configure(EntityTypeBuilder<Blockchain> builder)
        {
            builder.Property(b=> b.Id).IsRequired();
            //Rest configuration here
        }
    }
}