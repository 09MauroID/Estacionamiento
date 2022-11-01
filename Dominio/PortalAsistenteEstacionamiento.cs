namespace Dominio;

public class PortalAsistenteEstacionamiento
{
    public void EscaneoDeticket(string matricula)
    {
        var escaneo= this.Tickets.SingleOrDefault(x => x.matricula == matricula);
    }
}
