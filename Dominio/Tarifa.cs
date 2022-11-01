namespace Dominio;
{    public class Tarifa
{
    public double primeraHora;
    public double segundaHora;
    public double terceraHora;
    public double horasRestantes;

    public Tarifa(double primeraHora, double segundaHora, double terceraHora, double horasRestantes)
    {
        this.primeraHora= 400;
        this.segundaHora= 350;
        this.terceraHora= 250;
        this.horasRestantes= 250;
    }
    public void calcularMontoHorasTarifa(double  primeraHora, double segundaHora, double terceraHora, double horasRestantes)
    {
        var estadia = DateTime.Now - ticketEntrada.horarioIngreso;
        
        estadia.Minutes;
        
    }
}