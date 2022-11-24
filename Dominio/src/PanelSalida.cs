using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("PanelSalida")]
public class PanelSalida
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public TicketEntrada TicketSalida { get; set; }
    [StringLength(50)]
    [Required]
    public string? PagoTicket { get; set; }
    public PanelSalida(TicketEntrada TicketSalida, string PagoTicket)
    {
        this.TicketSalida = TicketSalida;
        this.PagoTicket = PagoTicket;
    }
}