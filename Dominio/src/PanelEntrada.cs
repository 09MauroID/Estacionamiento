using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Panelentrada")]
public class PanelEntrada
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public TicketEntrada ticketEntrada { get; set; }
    [StringLength(50)]
    [Required]
    public string ubicacion { get; set; }

    public PanelEntrada(TicketEntrada ticketEntrada, string ubicacion)
    {
        this.ticketEntrada = ticketEntrada;
        this.ubicacion = ubicacion;
    }
}