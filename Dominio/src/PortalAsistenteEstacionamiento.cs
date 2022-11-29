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

    public PortalAsistenteEstacionamiento()
    {
        this.Asistentes = new List<Asistente>();
    }


    public void EscaneoDeticket(string matricula)
    {
        //var escaneo = sistema.Tickets.SingleOrDefault(x => x.matricula == matricula);
    }
    
    public void AgregarAsistente(Asistente asistente) => this.Asistentes.Add(asistente);
}