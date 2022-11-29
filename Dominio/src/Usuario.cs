using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Usuario")]
public class Usuario
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    [Required]
    public string nombre { get; set; }
    [StringLength(50)]
    [Required]
    public string contraseña { get; set; }



    public Usuario(string nombre, string contraseña)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
    }

    public Usuario()
    {

    }
}