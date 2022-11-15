namespace Dominio.src;

public class PanelSalida
{
    public TicketEntrada TicketSalida { get; set; }
    public string? PagoTicket { get; set; }
    public PanelSalida(TicketEntrada TicketSalida, string PagoTicket)
    {
        this.TicketSalida = TicketSalida;
        this.PagoTicket = PagoTicket;
    }
}