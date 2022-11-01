using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Electrico : Slot
    {
        public byte carga;
        public Electrico (bool discapacitado, bool compacto, bool grande, bool motocicleta, bool electrico, byte carga)
        : base (discapacitado, compacto, grande, motocicleta, electrico)
        {
            this.carga = carga; 
        }
    }
}