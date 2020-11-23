using Microsoft.EntityFrameworkCore;
using System;
using TFTI.Contracts;

namespace Kalandear.Data
{
    public class TFTIContext : DbContext
    {
        public TFTIContext(DbContextOptions<TFTIContext> options): base(options) { }

        /// <summary>
        ///     EF Core Database set to handle hosts.
        /// </summary>
        public DbSet<User> Hosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Add configs
        }
    }
}
