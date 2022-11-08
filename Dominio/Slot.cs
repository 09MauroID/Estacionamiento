using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Slot
    {
        public bool discapacitado;
        public bool compacto;
        public bool grande;
        public bool motocicleta;
        public bool electrico;

        public Slot(bool discapacitado, bool compacto, bool grande, bool motocicleta, bool electrico)
        {
            this.discapacitado = discapacitado;
            this.compacto = compacto;
            this.grande = grande;
            this.motocicleta = motocicleta;
            this.electrico = electrico;
        }
    }
}