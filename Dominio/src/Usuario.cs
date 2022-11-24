using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Usuario")]
public class Usuario
{
    [Key]
    [Required]
    public Guid id;
    [StringLength(50)]
    [Required]
    public string nombre;
    [StringLength(50)]
    [Required]
    public string contraseña;

    public Usuario(string nombre, string contraseña)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
    }
}