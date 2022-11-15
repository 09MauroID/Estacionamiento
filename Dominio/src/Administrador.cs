namespace Dominio.src;

public class Administrador
{
    public Guid id { get; set; }
    public string? nombre { get; set; }
    public string? contraseña { get; set; }

    public List<Planta> plantas { get; set; }
    public List<Slot> slots { get; set; }
    public List<Asistente> asistentes { get; set; }

    public Administrador(Guid id, string nombre, string contraseña)

    {
        this.id = id;
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.plantas = new List<Planta>();
        this.slots = new List<Slot>();
        this.asistentes = new List<Asistente>();
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

    public void agregarlugares(Slot slot) => this.slots.Add(slot);

    public void agregarAsistente(Asistente asistente) => this.asistentes.Add(asistente);

    public void eliminarAsistente(Asistente asistente) => this.asistentes.Remove(asistente);

}