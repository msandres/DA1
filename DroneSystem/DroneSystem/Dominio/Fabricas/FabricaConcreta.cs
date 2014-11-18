using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public class FabricaConcreta: FabricaAbstracta
    {

        public FabricaConcreta()
        {
            FabricaAcelerometro = new FabricaConcretaAcelerometro();
            FabricaAltimetro = new FabricaConcretaAltimetro();
            FabricaBarometro = new FabricaConcretaBarometro();
            FabricaComponenteCompuesto = new FabricaConcretaComponenteCompuesto();
            FabricaGps = new FabricaConcretaGps();
            FabricaTermometro = new FabricaConcretaTermometro();
            FabricaVelocimetro = new FabricaConcretaVelocimetro();

            FabricaDron = new FabricaConcretaDron();
            FabricaPlanVuelo = new FabricaConcretaPlanVuelo();
        }

        public override ComponenteAbstracto CrearComponente(IList<object> configuracion)
        {
            ComponenteAbstracto compAbs = null;
            List<int> listaIdsLista = null; //pongo qué parametro va en que lista de paramaetros, sobre todo para las piezas con multiples variables, gps por ejemplo
            List<List<object>> listaListasPar = new List<List<object>>();
            string tipoComponente = configuracion[0].ToString();
            configuracion.RemoveAt(0);
            switch (tipoComponente)
            {
                case "Acelerómetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5, }); 
                    break;
                case "Altímetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
                    break;
                case "Barómetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
                    break;
                case "Componente Compuesto": listaIdsLista = new List<int>(new int[] { 0, 1, 2});
                    break;
                case "GPS": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5, });
                    break;
                case "Termómetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
                    break;
                case "Velocímetro": listaIdsLista = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5, });
                    break;
            }

            int idConf = 0;
            int idParam = -1;
            while (idConf < configuracion.Count)
            {
                if (idConf < listaIdsLista.Count)
                {
                     idParam = listaIdsLista[idConf];

                    if (listaListasPar.Count - 1 < idParam)
                    {
                        listaListasPar.Add(new List<object>());
                    }
                }
                listaListasPar[idParam].Add(configuracion[idConf]);

                idConf++;
            }

            switch (tipoComponente)
            {
                case "Acelerómetro": compAbs = FabricaAcelerometro.CrearDisenioAcelerometro(listaListasPar);
                    break;
                case "Altímetro": compAbs = FabricaAltimetro.CrearDisenioAltimetro(listaListasPar);
                    break;
                case "Barómetro": compAbs = FabricaBarometro.CrearDisenioBarometro(listaListasPar);
                    break;
                case "Componente Compuesto": compAbs = FabricaComponenteCompuesto.CrearDisenioCompuesto(listaListasPar);
                    break;
                case "GPS": compAbs = FabricaGps.CrearDisenioGps(listaListasPar); 
                    break;
                case "Termómetro": compAbs = FabricaTermometro.CrearDisenioTermometro(listaListasPar); 
                    break;
                case "Velocímetro": compAbs = FabricaVelocimetro.CrearDisenioVelocimetro(listaListasPar);
                    break;
            }

            return compAbs;
        }


        public override Dron CrearDron(String nombre, String color, String control,Double precio)
        {
            return  FabricaDron.CrearDisenioDron(nombre, color, control,precio);
        }


        public override PlanVuelo CrearPlanDeVuelo(String nombrePlan, List<double> recX, List<double> recY, List<double> recZ, Double velX, Double velY, Double velZ)
        {
            return FabricaPlanVuelo.CrearPlanDeVuelo(nombrePlan, recX, recY, recZ, velX, velY, velZ);
        }
    }
}
