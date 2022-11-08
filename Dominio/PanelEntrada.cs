
namespace Dominio
{
    public class PanelEntrada
    {
        public TicketEntrada ticketEntrada { get; set; }

        public PanelEntrada(TicketEntrada ticketEntrada)
        {
            this.ticketEntrada = ticketEntrada;
        }
    }
}