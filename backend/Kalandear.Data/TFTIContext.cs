using Microsoft.EntityFrameworkCore;
using TFTI.Contracts;

namespace Kalandear.Data
{
    public class TFTIContext : DbContext
    {
        public TFTIContext(DbContextOptions<TFTIContext> options): base(options) { }

        /// <summary>
        ///     EF Core Database set to handle hosts.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        ///     EF Core Database set to handle events.
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        ///     EF Core Database set to handle event attendees.
        /// </summary>
        public DbSet<EventAttendees> EventAttendees { get; set; }

        /// <summary>
        ///     EF Core Database set to handle event invites.
        /// </summary>
        public DbSet<EventInvites> EventInvites { get; set; }

        /// <summary>
        ///     EF Core Database set to handle friends.
        /// </summary>
        public DbSet<Friend> Friends { get; set; }

        /// <summary>
        ///     EF Core Database set to handle items.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        ///     EF Core Database set to handle media.
        /// </summary>
        public DbSet<Media> Media { get; set; }

        /// <summary>
        ///     EF Core Database set to handle messages.
        /// </summary>
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
