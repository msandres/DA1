using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Stock
{
    public interface IStock
    {
        void AgregarPlanVuelo(PlanVuelo plan);
        IList<PlanVuelo> GetPlanesVuelo();
        void EliminarPlanVuelo(PlanVuelo plan);
    }
}
