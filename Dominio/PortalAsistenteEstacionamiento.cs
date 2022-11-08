namespace Dominio;

public class PortalAsistenteEstacionamiento
{
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
