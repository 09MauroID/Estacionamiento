namespace Dominio.src;

public class Cliente
{
    public TicketEntrada ticketEntrada { get; set; }

    public Cliente(TicketEntrada ticketEntrada)
    {
        this.ticketEntrada = ticketEntrada;
    }

    public void pagarTicket()
    {

    }

    public void PagarPanelElectrico()
    {

    }
}