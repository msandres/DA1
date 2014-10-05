using DroneSystem.Dominio.Composite;
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

        void AgregarComponente(ComponenteAbstracto comp);
        IList<ComponenteAbstracto> GetComponentes();
        void EliminarComponente(ComponenteAbstracto comp);
        void AgregarDron(Dron dron);

        IList<Dron> GetDrones();

        void EliminarDron(Dron dron);
    }
}
