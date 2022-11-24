using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("PortalAsistenteEstacionamiento")]
public class PortalAsistenteEstacionamiento
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public List<Asistente> Asistentes { get; set; }

    public Sistema sistema { get; set; }
    public PortalAsistenteEstacionamiento(Sistema sistema)
    {
        this.Asistentes = new List<Asistente>();
        this.sistema = sistema;
    }
    public void EscaneoDeticket(string matricula)
    {
        var escaneo = sistema.Tickets.SingleOrDefault(x => x.matricula == matricula);
    }
}