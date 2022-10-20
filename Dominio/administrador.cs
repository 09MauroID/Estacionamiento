namespace Dominio;

public class administrador
{
    public Guid id { get; set; }
    public string? nombre { get; set; }
    public string? contraseña { get; set; }

    public List<Planta> plantas { get; set; }

    public administrador(Guid id, string nombre, string contraseña)
    {
        this.id = id;
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.plantas = new List<Planta>();
    }

    public void agregarPisos() => this.plantas.Add(plantas)

}
