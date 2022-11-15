namespace Dominio.src;

public class Pago
{
    public string? tipoPago { get; set; }
    public int montodePago { get; set; }

    public Pago(string tipoPago, int montodePago)
    {
        this.tipoPago = tipoPago;
        this.montodePago = montodePago;
    }
}