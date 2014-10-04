using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Stock
{
    public class Stock:Observable,IStock
    {

        private IList<PlanVuelo> listaPlanesVuelo;
        private IList<Dron> listaDrones;

        private static Stock instancia;


        private Stock()
        {
            listaPlanesVuelo = new List<PlanVuelo>();
            listaDrones = new List<Dron>();
            Observers = new List<IObserver>();

        }

        public static Stock GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Stock();
            }
            return instancia;
        }


        public void AgregarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Add(plan);
            Notify();
        }

        public IList<PlanVuelo> GetPlanesVuelo()
        {
            return this.listaPlanesVuelo;
        }

        public void EliminarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Remove(plan);
            Notify();
        }



        public override void Agregar(IObserver observer)
        {
            Observers.Add(observer);
        }

        public override void Remover(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
