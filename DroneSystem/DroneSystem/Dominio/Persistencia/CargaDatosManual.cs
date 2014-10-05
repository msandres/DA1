using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Persistencia
{
    public class CargaDatosManual:ICargaDatos
    {
        public void Cargar()
        { 
           
            List<object> parametrosConf = new List<object>();

            //Agrego Termometros
            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoSolar");
            parametrosConf.Add("TemS");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)50);
            parametrosConf.Add((double)-50);
            parametrosConf.Add((double)5);
                       
            Fachada.GetInstancia().CrearComponente(parametrosConf);

            parametrosConf = new List<object>();

            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoKing");
            parametrosConf.Add("TempK");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)60);
            parametrosConf.Add((double)-40);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);

            parametrosConf = new List<object>();

            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoKing");
            parametrosConf.Add("TempK2");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)60);
            parametrosConf.Add((double)-40);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);

            parametrosConf = new List<object>();

            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoCalor");
            parametrosConf.Add("TempC1");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)40);
            parametrosConf.Add((double)-40);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);
            //-------------------------------------------------------
            //Agrego Dron
            string nombre = "Dron 1";
            string color = "Rojo";
            string control = "Remoto Genérico";
            List<int> seleccion = new List<int>();
            seleccion.Add(1);
            Fachada.GetInstancia().CrearDron(nombre, color, control, seleccion);

            //-------------------------------------------------------
            //Agrego Planes

            List<double> recX = new List<double>();
            recX.Add(1);
            recX.Add(30);
            recX.Add(60);
            List<double> recY = new List<double>();
            recY.Add(1);
            recY.Add(20);
            recY.Add(40);
            List<double> recZ = new List<double>();
            recZ.Add(1);
            recZ.Add(20);
            recZ.Add(100);

            double velX = 1;
            double velY = 2;
            double velZ = 3;
                        
            Fachada.GetInstancia().CrearPlanDeVuelo("Plan Ejemplo", recX, recY, recZ, velX, velY, velZ);

        }
    }
}
