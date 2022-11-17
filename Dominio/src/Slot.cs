using Dominio.Enums;

namespace Dominio.src;

public class Slot
{
    public TipoSlot TipoSlot { get; set; }
    public TipoVehiculo tipoVehiculo { get; set; }

    public Slot(TipoSlot tipo, TipoVehiculo tipoVehiculo)
    {
        TipoSlot = tipo;
        this.tipoVehiculo = tipoVehiculo;
    }
}