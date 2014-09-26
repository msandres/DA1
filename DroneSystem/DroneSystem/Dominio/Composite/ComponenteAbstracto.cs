using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public abstract class ComponenteAbstracto : IComparable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int IdComponente { get; set; }  //usado para identificar un componente de otro
        protected static int IdComponenteClase { get; set; }   //para stockear los componentes

        public double Precision { get; set; }  

        private int tiempoAlarmado = 0;  //medido en segundos
        private bool destruido = false; // implementar el pasaje a true, cuando tiempoAlarmado > 5
        public bool Destruido
        {
            get
            {
                return destruido;
            }
        }




        //precision, maximo y minimo irá en la clase concreta no?
        //
        // se agregan las funciones de retorno de valor y solo se controla si pasó o no el umbral de alarma

        //unidades de medidas se ponen?

        public abstract IList<Object> ObtenerValorActual(); //obtiene el valor actual del sensor 
        public abstract IList<Object> ObtenerLimiteMaximo(); //obtiene el valor limite maximo
        public abstract IList<Object> ObtenerLimiteMinimo(); //obtiene el valor limite minimo
        public abstract IList<Object> ObtenerPrecision(); //obtiene el valor de precision
        public abstract bool Alarmado(); //alarma cuando pasa el minimo o el maximo, es recursivo para componentes


        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                return this.IdComponente == ((ComponenteAbstracto)obj).IdComponente;
            }

        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (this == obj) return 0;
            if ((this.Marca.CompareTo(((ComponenteAbstracto)obj).Marca) == 0))
            {
                if ((this.Modelo.CompareTo(((ComponenteAbstracto)obj).Modelo) == 0))
                {
                    return this.IdComponente.CompareTo(((ComponenteAbstracto)obj).IdComponente);
                }
                else
                {
                    return this.Modelo.CompareTo(((ComponenteAbstracto)obj).Modelo);
                }
            }
            else
            {
                return this.Marca.CompareTo(((ComponenteAbstracto)obj).Marca);
            }
        }


    }
}
