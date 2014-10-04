using DroneSystem.Dominio.Stock;
using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio
{
    public class Fachada
    {
        private static Fachada instancia;
        private IStock stock;

        private Fachada()
        {
            stock = Stock.Stock.GetInstancia();
        }

        public static Fachada GetInstancia()
        {
            if (instancia == null) instancia = new Fachada();
            return instancia;
        }

        public void AagregarObserverStock(IObserver observerStock)
        {
            ((Observable)stock).AgregarOb(observerStock);
        }

        public void RemoverObserverStock(IObserver observerStock)
        {
            ((Observable)stock).RemoverOb(observerStock);
        }
        
        public void CrearPlanDeVuelo(string nombrePlan ,List<double> recX,List<double> recY,List<double> recZ,
                                    double velX, double velY, double velZ)
        {
        PlanVuelo nuevoPlan = new PlanVuelo(nombrePlan,recX,recY,recZ,velX,velY,velZ);

        stock.AgregarPlanVuelo(nuevoPlan);

        }

        public IList<PlanVuelo> GetPlanesDeVuelo()
        {
            return stock.GetPlanesVuelo();
        }

        public void EliminarPlanDeVuelo(PlanVuelo plan)
        {
            stock.EliminarPlanVuelo(plan);
        }

    }
}
