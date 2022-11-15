namespace Dominio.src;

public class TicketEntrada
{
    public string? matricula { get; set; }
    public string? tipoVehiculo { get; set; }
    public DateTime horarioIngreso { get; set; }
    public int Monto { get; set; }
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