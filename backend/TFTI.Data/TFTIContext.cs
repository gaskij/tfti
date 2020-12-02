using Microsoft.EntityFrameworkCore;
using TFTI.Contracts;

namespace TFTI.Data
{
    public class TFTIContext : DbContext
    {
        public TFTIContext(DbContextOptions<TFTIContext> options) : base(options) { }

        /// <summary>
        ///     EF Core Database set to handle hosts.
        /// </summary>
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
