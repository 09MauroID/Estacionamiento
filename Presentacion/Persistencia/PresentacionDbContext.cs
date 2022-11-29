using Dominio.src;
using Microsoft.EntityFrameworkCore;

namespace Presentacion.Persistencia;

public class PresentacionDbContext : DbContext
{
    public PresentacionDbContext(DbContextOptions<PresentacionDbContext> opciones)
    : base(opciones)
    {

    }
    //public DbSet<Sistema> Sistemas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Estacionamiento> Estacionamientos { get; set; }
    public DbSet<Planta> Plantas { get; set; }
    public DbSet<Slot> Slots { get; set; }
    public DbSet<Administrador> Administradores { get; set; }
    public DbSet<Asistente> Asistentes { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<TicketEntrada> TicketEntradas { get; set; }
    public DbSet<PanelEntrada> PanelEntradas { get; set; }
    public DbSet<PanelSalida> PanelSalidas { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<PanelEstacionamiento> PanelEstacionamientos { get; set; }
    public DbSet<PortalAsistenteEstacionamiento> PortalAsistenteEstacionamientos { get; set; }
    public DbSet<PortalInformacionCliente> PortalInformacionClientes { get; set; }
    public DbSet<PanelElectrico> PanelElectricos { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
}
