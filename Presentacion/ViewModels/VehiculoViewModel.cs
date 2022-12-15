namespace Presentacion.ViewModels;

public class VehiculoViewModel
{
    public int TipoVehiculo { get; set; }
}

public class VehiculoAltaViewModel : VehiculoViewModel
{
    public int TipoVehiculo { get; set; }
    public string matricula { get; set; }
}
