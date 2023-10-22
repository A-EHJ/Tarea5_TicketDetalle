using Microsoft.EntityFrameworkCore;
using TicketDetalle.Shared;

namespace TicketDetalle.Server.DAL
{
    public class TicketContext : DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }
    }
}
