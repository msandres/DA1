using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public abstract class FabricaAbstracta
    {
        protected IFabricaAcelerometro FabricaAcelerometro { get; set; }
        protected IFabricaAltimetro FabricaAltimetro { get; set; }
        protected IFabricaBarometro FabricaBarometro { get; set; }
        protected IFabricaComponenteCompuesto FabricaComponenteCompuesto { get; set; }
        protected IFabricaGps FabricaGps { get; set; }
        protected IFabricaTermometro FabricaTermometro { get; set; }
        protected IFabricaVelocimetro FabricaVelocimetro { get; set; }

        public abstract ComponenteAbstracto CrearComponente(IList<object> configuracion);
    }
}
