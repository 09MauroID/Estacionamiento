using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Cliente")]
public class Cliente
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public TicketEntrada ticketEntrada { get; set; }

    public Cliente(TicketEntrada ticketEntrada)
    {
        this.ticketEntrada = ticketEntrada;
    }

    public Cliente()
    {
    }

    public void pagarTicket()
    {

    }

    public void PagarPanelElectrico()
    {

    }
}