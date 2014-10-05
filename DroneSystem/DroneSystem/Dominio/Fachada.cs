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
                case "Componente Compuesto": parametros = GetMarcaModeloComponentes();
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
            ComponenteAbstracto comp=null;
            string tipoComponente = configuracion[0].ToString();
            switch (tipoComponente)
            {
                case "Altímetro": //parametros = new Altimetro().ObtenerParametrizacion();
                    break;
                case "Barómetro": //parametros = new Barometro().ObtenerParametrizacion();
                    break;
                case "Componente Compuesto": //parametros = GetMarcaModeloComponentes();
                    break;
                case "GPS": //parametros = new Gps().ObtenerParametrizacion();
                    break;
                case "Termómetro": comp = CrearComponenteConcreto(configuracion);
                    break;
                case "Velocímetro": //parametros = new Velocimetro().ObtenerParametrizacion();
                    break;
            }
            
            stock.AgregarComponente(comp);
        }

        private ComponenteAbstracto CrearComponenteConcreto(IList<object> configuracion)
        {
            ComponenteAbstracto c = null;
            List<int> listaIdsLista = null; //pongo que parametro va en que lista de paramaetros, sobre todo para las piezas con multiples variables, gps por ejemplo
            List<List<object>> listaListasPar = new List<List<object>>();
            string tipoComponente = configuracion[0].ToString();
            configuracion.RemoveAt(0);
            switch (tipoComponente)
            {
                case "Altímetro": //parametros = new Altimetro().ObtenerParametrizacion();
                    break;
                case "Barómetro": //parametros = new Barometro().ObtenerParametrizacion();
                    break;
                case "Componente Compuesto": //parametros = GetMarcaModeloComponentes();
                    break;
                case "GPS": //parametros = new Gps().ObtenerParametrizacion();
                    break;
                case "Termómetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
                    break;
                case "Velocímetro": //parametros = new Velocimetro().ObtenerParametrizacion();
                    break;
            }

            int idConf = 0;
            while (idConf< configuracion.Count)
            {
                int idParam = listaIdsLista[idConf];

                if (listaListasPar.Count-1 < idParam)
                {
                    listaListasPar.Add(new List<object>());
                }
                listaListasPar[idParam].Add(configuracion[idConf]);
               
                idConf++;
            }

            switch (tipoComponente)
            {
                case "Altímetro": //parametros = new Altimetro().ObtenerParametrizacion();
                    break;
                case "Barómetro": //parametros = new Barometro().ObtenerParametrizacion();
                    break;
                case "Componente Compuesto": //parametros = GetMarcaModeloComponentes();
                    break;
                case "GPS": //parametros = new Gps().ObtenerParametrizacion();
                    break;
                case "Termómetro": c = new Termometro(listaListasPar[0][0].ToString(), listaListasPar[1][0].ToString(), listaListasPar[2], listaListasPar[3], listaListasPar[4], listaListasPar[5]);
                    break;
                case "Velocímetro": //parametros = new Velocimetro().ObtenerParametrizacion();
                    break;
            }

            return c;
        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return stock.GetComponentes();
        }

        //Se usa para las ventanas
        public IList<string> TiposComponente()
        { 
           List<string> listaTipos = new List<string>();
           listaTipos.Add("Altímetro");
           listaTipos.Add("Barómetro");
           listaTipos.Add("Componente Compuesto");
           listaTipos.Add("GPS");
           listaTipos.Add("Termómetro");
           listaTipos.Add("Velocímetro");

            return listaTipos;
        }

        //es usado para las ventanas
        public IList<string> GetMarcaModeloComponentes()
        {
            List<string> marcamodelo = new List<string>();

            foreach (ComponenteAbstracto cmp in GetComponentes())
            {
                marcamodelo.Add(cmp.Marca + ":" + cmp.Modelo);
            }

            return marcamodelo;
        }
    }
}
