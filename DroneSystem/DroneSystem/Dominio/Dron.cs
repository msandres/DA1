using DroneSystem.Dominio;
using DroneSystem.Dominio.Composite;
using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem
{
    public class Dron: Observable
    {
        private static int serieClase;  //mantengo el numero de serie de la clase, así creo un dron nuevo con un codigo nuevo cada vez

        private string Nombre;
        private int serieDron;
        private string color;
        private string controlRemoto;


        private  IList<ComponenteAbstracto> listcomponentes;
        private double X ;
        private double Y;
        private double Z ;


        private double avanceX;
        private double avanceY;
        private double avanceZ;


        //creo el dron por defecto en la posicion 0,0,0 y con velocidad de avance 1,1,1 y con la lista vacia
        public Dron(string nombreDron,string colorDron,string modeloControl)
        {
            serieClase++;  //aumento la serie global del dron
            this.Nombre = nombreDron;
            this.serieDron = serieClase;
            this.color = colorDron;
            this.controlRemoto = modeloControl;

            

            this.listcomponentes = new List<ComponenteAbstracto>();
            this.X = 0;
            this.Y = 0;
            this.Z = 0;

            this.avanceX = 1;
            this.avanceY = 1;
            this.avanceZ = 1;

            Observers = new List<IObserver>();

        }

        public void AgregarComponentes(List<ComponenteAbstracto> listaComp)
        {
            this.listcomponentes = listaComp;
            foreach (ComponenteAbstracto cmp in this.listcomponentes)
            {
                AgregarOb(cmp);
            }
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public int GetNroSerie()
        {
            return this.serieDron;
        }

        public double UbicacionX()
        {
            return this.X;
        }
        public double UbicacionY()
        {
            return this.Y;
        }
        public double UbicacionZ()
        {
            return this.Z;
        }

        public void IniciarVuelo(PlanVuelo plan)
        { 

        }


        public override void AgregarOb(IObserver observer)
        {
            Observers.Add(observer);
        }

        public override void RemoverOb(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}

