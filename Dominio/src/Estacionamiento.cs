using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Estacionamiento")]
public class Estacionamiento
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [StringLength(50)]
    [Required]
    public string? Nombre { get; set; }
    [StringLength(50)]
    [Required]
    public string? Direccion { get; set; }
    public Planta planta { get; set; }

    public Estacionamiento(string Nombre, string Direccion, Planta planta)
    {
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.planta = planta;

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}