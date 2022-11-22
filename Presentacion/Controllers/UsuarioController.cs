using System;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    //public PresentacionDbContext contexto { get; }
    //public UsuarioController(PresentacionDbContext contexto)
    //{
    //    this.contexto = contexto;
//
    //}
    //[HttpGet]
    //public ActionResult Get()
    //{
    //    var Usuario = contexto.Usuario;
    //    return OK(Usuarios);
    //}
    //[HttpGet("{id:Guid}")]
    //public ActionResult Get(Guid id)
    //{
    //    var Usuario = contexto.Usuario.FirstOrDefault(x => x.id == id);
    //    return Ok(Usuario);
    //}
    //[HttpGet]
    //public ActionResult Post([FromBody] UsuarioViewModel usuario)
    //{
    //    var nuevoUsuario = new Usuario(Usuario.Nombre, Usuario.Contraseña);
    //    contexto.Add(nuevoUsuario);
    //    contexto.SaveChanger();
    //    return StatusCode(StatusCodes.Status201Create);
//
    //}
}
