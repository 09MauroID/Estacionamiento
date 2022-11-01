using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class panelSalida
    {
        public string? TicketSalida;
        public string? PagoTicket;
        public panelSalida(string TicketSalida, string PagoTicket)
        {
            this.TicketSalida = TicketSalida;
            this.PagoTicket = PagoTicket;
        }

        
    }
}