namespace Dominio.src;

public class Asistente
{
    public Guid id { get; set; }
    public string? nombre { get; set; }
    public string? contrasenia { get; set; }

    public Asistente(Guid id, string nombre, string contrasenia)
    {
        this.id = id;
        this.nombre = nombre;
        this.contrasenia = contrasenia;
    }
}