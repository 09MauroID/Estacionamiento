using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Dominio.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

public class VehiculoController : ControllerBase
{
    public PresentacionDbContext contexto { get; }
    public VehiculoController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var vehiculos = contexto.Vehiculos;
        return Ok(vehiculos);
    }
    [HttpPost]
    public ActionResult Post([FromBody] VehiculoAltaViewModel vehiculo)
    {
        var nuevoVehiculo = new Vehiculo(vehiculo.matricula, (TipoVehiculo)vehiculo.TipoVehiculo);
        contexto.Add(nuevoVehiculo);
        contexto.SaveChanges();
        //return StatusCode(StatusCodes.Status201Created, nuevoVehiculo);
        return Created($"api/Vehiculo/{vehiculo.matricula}", vehiculo);
    }

    [HttpPut("{matricula}")]
    public ActionResult Put([FromBody] VehiculoViewModel vehiculo, string matricula)
    {
        var vehiculoModificar = contexto.Vehiculos.FirstOrDefault(x => x.matricula == matricula);
        if (vehiculoModificar is null)
            throw new Exception("no existe un vehiculo con ese Id.");



        vehiculoModificar.Actualizar(vehiculo.TipoVehiculo);

        contexto.SaveChanges();

        return Ok(vehiculoModificar);
    }

    [HttpDelete("{matricula}")]
    public ActionResult Delete(string matricula)
    {
        var vehiculoBorrar = contexto.Vehiculos.FirstOrDefault(x => x.matricula == matricula);
        if (vehiculoBorrar is null)
            throw new Exception("no existe un vehiculo con ese Id.");


        contexto.Vehiculos.Remove(vehiculoBorrar);

        contexto.SaveChanges();

        return Ok();
    }
}