using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public class FabricaConcretaPlanVuelo:IFabricaPlanVuelo
    {
        public PlanVuelo CrearPlanDeVuelo(String nombrePlan, List<double> recX, List<double> recY, List<double> recZ, Double velX, Double velY, Double velZ)
        { 
            return new PlanVuelo(nombrePlan, recX, recY, recZ, velX, velY, velZ);
        }

    }
}
