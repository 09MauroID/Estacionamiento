using Dominio.Enums;
namespace Dominio.src;

public class Vehiculo
{
    public string matricula { get; set; }
    public TipoVehiculo tipoVehiculo { get; set; }

    public Vehiculo(string matricula, TipoVehiculo tipoVehiculo)
    {
        this.matricula = matricula;
        this.tipoVehiculo = tipoVehiculo;
    }
}