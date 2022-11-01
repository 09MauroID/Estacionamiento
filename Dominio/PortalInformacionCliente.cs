namespace Dominio;

public class PortalInformacionCliente
{
    public void ActualizarTicket(TicketEntrada ticketEntrada)
    {
        var estadia = DateTime.Now - ticketEntrada.horarioIngreso;

        estadia.Minutes;
    }
}