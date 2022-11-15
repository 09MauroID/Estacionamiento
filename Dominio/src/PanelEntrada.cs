namespace Dominio.src;

public class PanelEntrada
{
    public TicketEntrada ticketEntrada { get; set; }

    public string ubicacion { get; set; }

    public PanelEntrada(TicketEntrada ticketEntrada, string ubicacion)
    {
        this.ticketEntrada = ticketEntrada;
        this.ubicacion = ubicacion;
    }
}