using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
