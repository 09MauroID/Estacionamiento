namespace Dominio.src;

public class Sistema
{
    public List<Usuario> Usuarios { get; set; }
    public List<TicketEntrada> Tickets { get; set; }
    public List<Administrador> Administradores { get; set; }
    public Estacionamiento Estacionamiento { get; set; }
    public PortalAsistenteEstacionamiento portalAsistenteEstacionamiento { get; set; }
    public PortalInformacionCliente PortalInformacionCliente { get; set; }
    public PanelElectrico PanelElectrico { get; set; }

    public Sistema(Estacionamiento estacionamiento, PortalAsistenteEstacionamiento portalAsistenteEstacionamiento, PortalInformacionCliente portalInformacionCliente, PanelElectrico panelElectrico)
    {
        this.Usuarios = new List<Usuario>();
        this.Tickets = new List<TicketEntrada>();
        this.Administradores = new List<Administrador>();
        this.Estacionamiento = estacionamiento;
        this.portalAsistenteEstacionamiento = portalAsistenteEstacionamiento;
        this.PortalInformacionCliente = portalInformacionCliente;
        this.PanelElectrico = panelElectrico;
    }
    public void CrearUsuario(string nombre, string contraseña) => this.Usuarios.Add(new Usuario(nombre, contraseña));

    public void EliminarUsuario(string nombre, string contraseña)
    {
        var usuario = this.Usuarios.SingleOrDefault(x => x.contraseña == contraseña);

        if (usuario is null)

            throw new Exception($"No existe usuario con id:{contraseña}");

        this.Usuarios.Remove(usuario);
    }

    public void emitirTicket() => System.Console.WriteLine();
}