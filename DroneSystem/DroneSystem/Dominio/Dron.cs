using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem
{
    public class Dron
    {
        private  IList<ComponenteAbstracto> listcomponentes;
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }


        private double avanceX { get; set; }
        private double avanceY { get; set; }
        private double avanceZ { get; set; }


        //creo el dron por defecto en la posicion 0,0,0 y con velocidad de avance 1,1,1 y con la lista vacia
        public Dron()
        {
            this.listcomponentes = new List<ComponenteAbstracto>();
            this.X = 0;
            this.Y = 0;
            this.Z = 0;

            this.avanceX = 1;
            this.avanceY = 1;
            this.avanceZ = 1;
        }

        //tengo que hacer las funciones que determinan el avance del dron
        //y lo hacen avanzar


    }
}

