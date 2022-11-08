namespace Dominio;

public class TicketEntrada
{
    public string? matricula;
    public string? tipoVehiculo;
    public DateTime horarioIngreso;
    public int Monto;
    public PanelSalida panelSalida { get; set; }

    public TicketEntrada(string matricula, string tipoVehiculo, DateTime horarioIngreso, PanelSalida panelSalida, int Monto)
    {
        this.matricula = matricula;
        this.tipoVehiculo = tipoVehiculo;
        this.horarioIngreso = horarioIngreso;
        this.panelSalida = panelSalida;
        this.Monto = Monto;
    }

}
