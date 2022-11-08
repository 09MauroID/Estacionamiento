namespace Dominio;
public class PanelSalida
{
    public string? TicketSalida;
    public string? PagoTicket;
    public PanelSalida(string TicketSalida, string PagoTicket)
    {
        this.TicketSalida = TicketSalida;
        this.PagoTicket = PagoTicket;
    }
}