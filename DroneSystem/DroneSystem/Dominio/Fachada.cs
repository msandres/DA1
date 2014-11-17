using DroneSystem.Dominio.Composite;
using DroneSystem.Dominio.Fabricas;
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
        private FabricaAbstracta fabrica;
        private static Dron dronActivo = null;


        private Fachada()
        {
            stock = Stock.Stock.GetInstancia();
            fabrica = new FabricaConcreta();
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
                case "Acelerómetro": parametros = new Acelerometro().ObtenerParametrizacion();
                    break;
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
        public void AagregarObserverDron(IObserver observerDron)
        {
            ((Observable)GetDronActivo()).AgregarOb(observerDron);
        }

        public void RemoverObserverStock(IObserver observerStock)
        {
            ((Observable)stock).RemoverOb(observerStock);
        }
        public void RemoverObserverDron(IObserver observerDron)
        {
            foreach (Dron dron in GetDrones())
            {
                ((Observable)dron).RemoverOb(observerDron);
            }
            
        }

        public void CrearPlanDeVuelo(string nombrePlan, List<double> recX, List<double> recY, List<double> recZ,
                                    double velX, double velY, double velZ)
        {
            PlanVuelo nuevoPlan = fabrica.CrearPlanDeVuelo(nombrePlan, recX, recY, recZ, velX, velY, velZ);
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

        public void CrearDron(string nombre, string color, string control, double precio, List<int> idComponentes)
        {
            Dron nuevoDron = fabrica.CrearDron(nombre, color, control,precio);
            List<ComponenteAbstracto> componentesDron = new List<ComponenteAbstracto>();

            foreach (int id in idComponentes)
            {
                componentesDron.Add(GetComponentes()[id]);
                GetComponentes()[id].AsignarDron(nuevoDron);
                stock.EliminarComponente(GetComponentes()[id]);
            }
            nuevoDron.AgregarComponentes(componentesDron);
            stock.AgregarDron(nuevoDron);
        }

        public void EliminarDron(Dron dron)
        {
            stock.EliminarDron(dron);
        }

        public IList<Dron> GetDrones()
        {
            return stock.GetDrones();
        }

        private Dron GetDronActivo()
        {
            return dronActivo;
        }

        public Boolean DronFuncionando()
        {
            return dronActivo.Funciona();
        }

        public Boolean DronVolando()
        {
            return dronActivo.EnMovimiento();
        }

        public void TerminarVueloDron()
        {
            if (GetDronActivo()!=null)
                GetDronActivo().DetenerVuelo();
        }

        public void LiberarDronActivo()
        {
            dronActivo = null;
        }

        public void IniciarVuelo(int iDdron, int iDplan)
        {
            GetDrones()[iDdron].IniciarVuelo(GetPlanesDeVuelo()[iDplan]);
            dronActivo = GetDrones()[iDdron];
        }

        //informacion para que las ventanas muestren dinamicamente los valores
        public List<List<string>> InfoDronActivo()
        {
            List<List<string>> listaInfo = new List<List<string>>(); 
            Dron dron = GetDronActivo();
            if (dron != null)
            {
                //agrego informacion del dron en la primer lista
                List<string> infoDron = new List<string>();
                infoDron.Add(dron.GetNombre());
                infoDron.Add(dron.GetNroSerie().ToString());
                infoDron.Add(dron.GetColor());

                listaInfo.Add(infoDron);

                List<string> infoComp = null;
                foreach (ComponenteAbstracto cmp in dron.GetComponentes())
                {
                    infoComp = new List<string>();
                    infoComp.Add(cmp.Marca);
                    infoComp.Add(cmp.Modelo);
                    foreach (var idVal in cmp.ObtenerValorActual())
                        infoComp.Add(idVal.ToString());
                    if (cmp.Alarmado())
                        infoComp.Add("ALARMA");
                    listaInfo.Add(infoComp);
                }
            }
            return listaInfo ;
        }

        public void CrearComponente(IList<object> configuracion)
        //string marca,string modelo,IList<string> unidades,IList<double> max,IList<double> min, IList<double> precision)
        {
            ComponenteAbstracto comp = fabrica.CrearComponente(configuracion);
            stock.AgregarComponente(comp);
        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return stock.GetComponentes();
        }

        //Se usa para las ventanas
        public IList<string> TiposComponente()
        {
            List<string> listaTipos = new List<string>();
            listaTipos.Add("Acelerómetro");
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
