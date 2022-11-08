namespace Dominio;

public class PortalInformacionCliente
{
    public string? TicketSalida;
    public string? PagoTicket;
    public TicketEntrada ticketEntrada { get; set; }
    public PortalInformacionCliente(string TicketSalida, string PagoTicket, TicketEntrada ticketEntrada)
    {
        this.TicketSalida = TicketSalida;
        this.PagoTicket = PagoTicket;
        this.ticketEntrada = ticketEntrada;
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