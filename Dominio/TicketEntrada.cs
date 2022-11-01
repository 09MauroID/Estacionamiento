namespace Dominio;

public class TicketEntrada
{
    public string? matricula;
    public string? tipoVehiculo;
    public DateTime horarioIngreso;

    public TicketEntrada(string matricula, string tipoVehiculo, DateTime horarioIngreso)
    {
        this.matricula = matricula;
        this.tipoVehiculo = tipoVehiculo;
        this.horarioIngreso = horarioIngreso;
    }

}
