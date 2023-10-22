using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketDetalle.Shared
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El Asunto es requerido")]
        public string? Asunto { get; set; }

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
