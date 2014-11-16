using DroneSystem.IPersistenciaPack;
using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public abstract class ComponenteAbstracto : OPersistente, IComparable, IObserver
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        protected IList<double> valor;
        protected IList<string> unidades;
        protected IList<double> valorMax;
        protected IList<double> valorMin;
        protected IList<double> valorPrecision;


        public Dron dronMedido { get; set; }
       // public int IdComponente { get; set; }  //usado para identificar un componente de otro
      //  protected static int IdComponenteClase { get; set; }   //para stockear los componentes

        protected int tiempoAlarmado = 0;  //medido en segundos
        protected bool destruido = false; // implementar el pasaje a true, cuando tiempoAlarmado > 5
        protected bool alarmado = false;
        

 
        // se agregan las funciones de retorno de valor y solo se controla si pasó o no el umbral de alarma

        public virtual IList<Object> ObtenerValorActual() //obtiene el valor actual del sensor 
        { 
            IList<object> listaRet = this.valor.Select(o => (object)o).ToList();
            return listaRet;
        }

        public virtual IList<Object> ObtenerUnidades() //obtiene las unidades en las que mide el sensor
        {
                IList<object> listaRet = this.unidades.Select(o => (object)o).ToList();
                return listaRet;
        }

        public virtual IList<Object> ObtenerLimiteMaximo() //obtiene el valor limite maximo
        {
            IList<object> listaRet = this.valorMax.Select(o => (object)o).ToList();
            return listaRet;
        }
        public virtual IList<Object> ObtenerLimiteMinimo() //obtiene el valor limite minimo
        {
            IList<object> listaRet = this.valorMin.Select(o => (object)o).ToList();
            return listaRet;
        }

        public virtual IList<Object> ObtenerPrecision() //obtiene el valor de precision
        {
            IList<object> listaRet = this.valorPrecision.Select(o => (object)o).ToList();
            return listaRet;
        }

        public abstract IList<string> ObtenerParametrizacion(); //obtiene el nombre de las variables con las que cuenta el tipo, se para llenar ventanas
        public abstract void ResetarValores(); //deja los valores por defectos de un sensor, como si los mismo no estuvieran midiendo nada

        public virtual bool Destruido()
        {
            return this.destruido;
        }

        public virtual bool Alarmado() //alarma cuando pasa el minimo o el maximo, es recursivo para componentes
        {
            return this.alarmado;
        }
        
        //calcula el valor de la pieza en funcion de la ubicación X,Y,Z
        public virtual void SetValor(double X,double Y, double Z)
        {
            CalcularValor(X,Y,Z);
        }

        protected abstract void CalcularValor(double X, double Y, double Z);

        public void Actualizar()
        {
            double ubicX = this.dronMedido.UbicacionX();
            double ubicY = this.dronMedido.UbicacionY();
            double ubicZ = this.dronMedido.UbicacionZ();

            SetValor(ubicX, ubicY, ubicZ);
        }

        public void AsignarDron(Dron dron)
        {
            this.dronMedido = dron;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                return this.Marca == ((ComponenteAbstracto)obj).Marca && this.Modelo == ((ComponenteAbstracto)obj).Modelo;
            }

        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (this == obj) return 0;
            if ((this.Marca.CompareTo(((ComponenteAbstracto)obj).Marca) == 0))
            {
                //if ((this.Modelo.CompareTo(((ComponenteAbstracto)obj).Modelo) == 0))
                //{
                //    return this.IdComponente.CompareTo(((ComponenteAbstracto)obj).IdComponente);
                //}
                //else
                //{
                    return this.Modelo.CompareTo(((ComponenteAbstracto)obj).Modelo);
                //}
            }
            else
            {
                return this.Marca.CompareTo(((ComponenteAbstracto)obj).Marca);
            }
        }


    }
}
