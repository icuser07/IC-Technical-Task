using BlockCypher.Domain.Entities;
using BlockCypher.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Infrastructure.Persistence
{
    public class BlockCypherDbContext : DbContext
    {
        public DbSet<Blockchain> Blockchains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BlockCypher");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlockchainConfiguration().Configure(modelBuilder.Entity<Blockchain>());

            base.OnModelCreating(modelBuilder);
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public virtual async Task<int> CommitAsync()
        {
            return await base.SaveChangesAsync();
        }

        public virtual async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}