using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Asistente")]
public class Asistente
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    [Required]
    public string? nombre { get; set; }
    [StringLength(50)]
    [Required]
    public string? contrasenia { get; set; }
    public Usuario? usuario { get; set; }

    public Asistente(string nombre, string contrasenia)
    {
        this.nombre = nombre;
        this.contrasenia = contrasenia;
    }
    public void Actualizar(string nombre, string contrasenia)
    {
        this.nombre = nombre;
        this.contrasenia = contrasenia;
    }
    public void AsignarUsuario(Usuario usuario) => this.usuario = usuario;
}