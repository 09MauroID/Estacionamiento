namespace Dominio;

public class Asistente
{
    public Guid id { get; set; }
    public string? nombre { get; set; }
    public string? contrasenia { get; set; }
    public int tarjetaCredito { get; set; }
    public int efectivo { get; set; }
}
