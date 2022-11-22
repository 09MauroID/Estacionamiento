using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

    public class PortalInformacionClienteController : ControllerBase
    {
        public PresentacionDbContext contexto { get; }
        public PortalInformacionClienteController(PresentacionDbContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var portalInformacionClientes = contexto.PortalInformacionClientes;
            return Ok(portalInformacionClientes);
        }
    }