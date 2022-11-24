using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;

[Table("PanelEstacionamento")]
public class PanelEstacionamiento
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [Required]
    public int espacioslibres { get; set; }

    public PanelEstacionamiento(int espacioslibres)
    {
        this.espacioslibres = espacioslibres;
    }

}