using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Dominio.src;
using Dominio.Enums;

namespace Tests
{
    public class AdministradorTest
    {
        [Fact]
        public void AgregarPisos_CuandoAdministradorAgregaPiso_DebeRetornarVerdadero()
        {
            var administrador = new Administrador("Mauro", "123");
            var planta = new Planta(1);
            administrador.agregarPisos(planta);
            Assert.Contains(planta, administrador.plantas);
        }
        [Fact]
        public void agregarlugares_CuandoAdministradorAgregaLugares_DebeRetornarVerdadero()
        {
            var administrador = new Administrador("Mauro", "123");
            var slot = new Slot(TipoSlot.discapacitado, TipoVehiculo.motocicleta);
            administrador.agregarlugares(slot);
            Assert.Contains(slot, administrador.slots);
        }
        [Fact]
        public void agregarAsistente_CuandoAdministradorAgregaAsistentes_DebeRetornarVerdadero()
        {
            var administrador = new Administrador("Mauro", "123");
            var asistente = new Asistente("Jose", "321");
            administrador.agregarAsistente(asistente);
            Assert.Contains(asistente, administrador.asistentes);
        }
        [Fact]
        public void eliminarPisos_CuandoAdministradorElimaPisos_DebeRetornarVerdadero()
        {
            var administrador = new Administrador("Mauro", "123");
            var planta = new Planta(1);
            administrador.agregarPisos(planta);
            administrador.eliminarPisos(planta);
            Assert.DoesNotContain(planta, administrador.plantas);
        }
        [Fact]
        public void eliminarAsistente_CuandoAdministradorEliminaAsistente_DebeRetornarVerdadero()
        {
            var administrador = new Administrador("Mauro", "123");
            var asistente = new Asistente("Jose", "321");
            administrador.agregarAsistente(asistente);
            administrador.eliminarAsistente(asistente);
            Assert.DoesNotContain(asistente, administrador.asistentes);
        }
    }
}