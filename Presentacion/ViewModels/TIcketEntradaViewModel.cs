namespace Presentacion.ViewModels;

public class TicketEntradaViewModel
{
    public Guid id { get; set; }
    public string matricula { get; set; }
    public string tipoVehiculo { get; set; }
    public DateTime horarioIngreso { get; set; }
    public int Monto { get; set; }
}
