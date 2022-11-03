namespace Dominio;

public class Administrador
{
    public Guid id { get; set; }
    public string? nombre { get; set; }
    public string? contraseña { get; set; }

    public List<Planta> plantas { get; set; }
    public List<Slot> slots { get; set; }

    public Administrador(Guid id, string nombre, string contraseña)

    {
        this.id = id;
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.plantas = new List<Planta>();
        this.slots = new List<Slot>();
    }

    public void agregarPisos(Planta planta) => this.plantas.Add(planta);

    public void eliminarPisos(Planta planta) => this.plantas.Remove(planta);

    public void modificarPiso(int nroPiso, Planta planta)
    {
        var pisobuscado = this.plantas.SingleOrDefault(x => x.nroPiso == nroPiso);

        if (pisobuscado is null)
            throw new Exception($"no se encontro el piso  {nroPiso}, se encuentra {planta.habilitado}");

        pisobuscado.habilitado = planta.habilitado;
        pisobuscado.vehiculo = pisobuscado.vehiculo;
        pisobuscado.ubicacion = pisobuscado.ubicacion;
        pisobuscado.slots = pisobuscado.slots;
    }

    public void agregarPisos(Slot slot) => this.slots.Add(slot);

    public
}
