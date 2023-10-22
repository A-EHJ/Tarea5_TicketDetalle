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

        [Required(ErrorMessage = "Es necesario completar el campo SolicitadoPor")]
        public string? SolicitadoPor { get; set; } // Persona que solicita

        [Required(ErrorMessage = "Es necesario completar el campo Asunto")]
        public string? Asunto { get; set; } // Asunto del ticket

        [Required(ErrorMessage = "Es necesario completar el campo Descripcion")]
        public string? Descripcion { get; set; } // Descripción del ticket

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
