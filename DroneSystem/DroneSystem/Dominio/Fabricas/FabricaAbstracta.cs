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

        protected IFabricaDron FabricaDron { get; set; }
        protected IFabricaPlanVuelo FabricaPlanVuelo { get; set; }

        //Métodos
        public abstract ComponenteAbstracto CrearComponente(IList<object> configuracion);

        public abstract Dron CrearDron(String nombre, String color, String control);

        public abstract PlanVuelo CrearPlanDeVuelo(String nombrePlan, List<double> recX, List<double> recY, List<double> recZ, Double velX, Double velY, Double velZ);
    }
}
