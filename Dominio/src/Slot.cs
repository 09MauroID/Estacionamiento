using Dominio.Enums;

namespace Dominio.src;

public class Slot
{
    public TipoSlot TipoSlot { get; set; }

    public Slot(TipoSlot tipo)
    {
        TipoSlot = tipo;

    }
}