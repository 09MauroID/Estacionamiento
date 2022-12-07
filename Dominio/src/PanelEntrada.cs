using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Panelentrada")]
public class PanelEntrada
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public List<TicketEntrada> ticketEntradas { get; set; }

    [StringLength(50)]
    [Required]
    public string ubicacion { get; set; }

    public PanelEntrada(string ubicacion)
    {
        this.ubicacion = ubicacion;
        this.ticketEntradas = new List<TicketEntrada>();
    }

    public PanelEntrada()
    {
        this.ticketEntradas = new List<TicketEntrada>();
    }

    public void Actualizar(string ubicacion)
    {
        this.ubicacion = ubicacion;
    }

    public void AgregarTicketEntrada(TicketEntrada ticketEntrada) => this.ticketEntradas.Add(ticketEntrada);
}