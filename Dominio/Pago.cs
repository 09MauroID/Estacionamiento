using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        public string? tipoPago;
        public int montodePago;

        public Pago(string tipoPago, int montodePago)
        {
            this.tipoPago = tipoPago;
            this.montodePago = montodePago; 
        }

    }
}