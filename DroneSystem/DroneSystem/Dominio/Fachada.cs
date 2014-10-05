using DroneSystem.Dominio.Composite;
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

        public IList<string> ObtenerParametros(string tipo)
        {
            IList<string> parametros = null;
            switch (tipo)
            {
                case "Altímetro": parametros = new Altimetro().ObtenerParametrizacion();
                    break;
                case "Barómetro": parametros = new Barometro().ObtenerParametrizacion();
                    break;
                case "GPS": parametros = new Gps().ObtenerParametrizacion();
                    break;
                case "Termómetro": parametros = new Termometro().ObtenerParametrizacion();
                    break;
                case "Velocímetro": parametros = new Velocimetro().ObtenerParametrizacion();
                    break;
            }

            return parametros;
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

        public void CrearComponente(IList<object> configuracion)
            //string marca,string modelo,IList<string> unidades,IList<double> max,IList<double> min, IList<double> precision)
        {
            string tipoComponente = configuracion[0].ToString();
            //ComponenteAbstracto cmp = new Termometro(marca,modelo,unidades,max,min,precision);
           // stock.AgregarComponente(cmp);

            

        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return stock.GetComponentes();
        }

    }
}
