using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;

[Table("PortalInformacionCliente")]
public class PortalInformacionCliente
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    [Required]
    public string? TicketSalida { get; set; }
    [StringLength(50)]
    [Required]
    public string? PagoTicket { get; set; }
    public TicketEntrada ticketEntrada { get; set; }
    public PortalInformacionCliente(string TicketSalida, string PagoTicket, TicketEntrada ticketEntrada)
    {
        this.TicketSalida = TicketSalida;
        this.PagoTicket = PagoTicket;
        this.ticketEntrada = ticketEntrada;
    }

    public PortalInformacionCliente()
    {
    }

    public void ActualizarTicket(TicketEntrada ticketEntrada)
    {

        var estadia = DateTime.Now - ticketEntrada.horarioIngreso;

        var minutos = Convert.ToInt32(estadia.TotalMinutes);

        if (minutos <= 60)
        {
            minutos = minutos - 60;
            System.Console.WriteLine("Monto a pagar : $400");
        }

        if (minutos <= 120)
        {
            minutos = minutos - 120;
            System.Console.WriteLine("Monto a pagar : $750");
        }
        if (minutos <= 180)
        {
            minutos = minutos - 180;
            System.Console.WriteLine("Monto a pagar : $1100");
        }
        if (minutos <= 240)
        {
            minutos = minutos - 240;
            System.Console.WriteLine("Monto a pagar : $1350");
        }

        while (minutos == 0)
        {
            minutos = minutos - 60;
            ticketEntrada.Monto = ticketEntrada.Monto + 250;
            System.Console.WriteLine($"Monto a pagar : ${ticketEntrada.Monto}");
        }


    }
}