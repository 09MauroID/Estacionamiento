using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
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
    public ActionResult Post([FromBody] VehiculoViewModel vehiculo)
    {
        var nuevoVehiculo = new Vehiculo(vehiculo.matricula,);
        contexto.Add(nuevoVehiculo);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }
}