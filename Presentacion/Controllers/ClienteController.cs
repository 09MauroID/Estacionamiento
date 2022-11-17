using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]


public class ClienteController : ControllerBase
{
    public PresentaciondbContexto contexto { get; }
    public ClienteController(PresentaciondbContexto contexto)
    {
        this.contexto = contexto;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var Clientes = contexto.Clientes;
        return Ok(Clientes);
    }


}
