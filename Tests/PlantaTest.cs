using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Dominio.src;
using Dominio.Enums;

namespace Tests
{
    public class PlantaTest
    {
        [Fact]
        public void AgregarSlot_CuandoPlantaAgregarSlot_DebeRetornarVerdadero()
        {
            var planta = new Planta(1);
            var slot = new Slot(TipoSlot.motocicleta, TipoVehiculo.motocicleta);
            planta.AgregarSlot(slot);
            Assert.Contains(slot, planta.slots);
        }
    }
}