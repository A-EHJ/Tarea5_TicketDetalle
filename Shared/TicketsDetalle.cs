using System.ComponentModel.DataAnnotations;

namespace TicketDetalle.Shared
{
    public class TicketsDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string? Emisor { get; set; }
        public string? Mensaje { get; set; }

    }
}