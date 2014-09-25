using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public abstract class ComponenteAbstracto : IComparable
    {
        public string Marca {get;set;}
        public string Modelo {get; set; } 
        public int IdComponente { get; set; }  //usado para identificar un componente de otro
        
        private int tiempoAlarmado=0;  //medido en segundos
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

        public virtual string ObtenerValorActual(); //obtiene el valor actual del sensor 
        public virtual bool Alarmado(); //alarma cuando pasa el minimo o el maximo, es recursivo para componentes


        

    }
}
