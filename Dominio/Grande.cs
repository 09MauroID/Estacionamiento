using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Grande : Slot
    {
        public Grande(bool discapacitado, bool compacto, bool grande, bool motocicleta, bool electrico)
            : base(discapacitado, compacto, grande, motocicleta, electrico)
        {

        }
    }
}