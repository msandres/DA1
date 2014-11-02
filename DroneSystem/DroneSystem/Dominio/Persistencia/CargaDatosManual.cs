using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Persistencia
{
    public class CargaDatosManual : ICargaDatos
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

            parametrosConf.Add("TermoP");
            parametrosConf.Add("TempP");
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

            parametrosConf = new List<object>();

            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoAlerta");
            parametrosConf.Add("TempA");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)22.2);
            parametrosConf.Add((double)-40);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);

            parametrosConf = new List<object>();

            parametrosConf.Add("Termómetro");

            parametrosConf.Add("TermoAlerta2");
            parametrosConf.Add("TempA2");
            parametrosConf.Add("°C");
            parametrosConf.Add((double)22.88);
            parametrosConf.Add((double)-40);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);
            //-------------------------------------------------------
            //Agrego GPS
            parametrosConf = new List<object>();

            parametrosConf.Add("GPS");

            parametrosConf.Add("Garmin");
            parametrosConf.Add("GM1500");
            parametrosConf.Add("M");
            parametrosConf.Add((double)10000);
            parametrosConf.Add((double)-10000);
            parametrosConf.Add((double)1);
            parametrosConf.Add("M");
            parametrosConf.Add((double)10000);
            parametrosConf.Add((double)-10000);
            parametrosConf.Add((double)1);
            parametrosConf.Add("M");
            parametrosConf.Add((double)10000);
            parametrosConf.Add((double)-10000);
            parametrosConf.Add((double)1);

            Fachada.GetInstancia().CrearComponente(parametrosConf);

            //---------------------
            //Agrego Dron
            string nombre = "Dron 1 (un Termometro)";
            string color = "Rojo";
            string control = "Remoto Genérico";
            List<int> seleccion = new List<int>();
            seleccion.Add(1);
            Fachada.GetInstancia().CrearDron(nombre, color, control, seleccion);

            nombre = "Dron 2 (Termometros y GPS)";
            color = "Azul";
            control = "Remoto TG";
            seleccion = new List<int>();
            seleccion.Add(4);
            seleccion.Add(5);
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

            recX = new List<double>();
            recX.Add(1);
            recX.Add(30);
            recX.Add(60);
            recY = new List<double>();
            recY.Add(1);
            recY.Add(20);
            recY.Add(1);
            recZ = new List<double>();
            recZ.Add(1);
            recZ.Add(20);
            recZ.Add(100);

            velX = 1;
            velY = 3;
            velZ = 1;

            Fachada.GetInstancia().CrearPlanDeVuelo("Plan Ejemplo 2", recX, recY, recZ, velX, velY, velZ);
        }
    }
}
