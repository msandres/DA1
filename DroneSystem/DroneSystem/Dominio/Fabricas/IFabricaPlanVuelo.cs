using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public interface IFabricaPlanVuelo
    {
        PlanVuelo CrearPlanDeVuelo(String nombrePlan, List<double> recX, List<double> recY, List<double> recZ, Double velX, Double velY, Double velZ);
    }
}
