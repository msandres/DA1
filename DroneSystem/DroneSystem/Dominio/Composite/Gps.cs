using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Gps:ComponenteAbstracto
    {
        private IList<double> valorAct;
        private IList<string> unidadesCoord;
        private IList<double> valorMax;
        private IList<double> valorMin;
        private IList<double> valorPrecision;

        public Gps(string marca, string modelo, IList<object> unidades, IList<object> max, IList<object> min, IList<object> precision)
         {
             this.Marca = marca;
             this.Modelo = modelo;
             this.unidadesCoord = unidades.Select(s => (string)s).ToList();
             this.valorMax = max.Select(s => (double)s).ToList();
             this.valorMin = min.Select(s => (double)s).ToList();
             this.valorPrecision = precision.Select(s => (double)s).ToList();

             this.valorAct = new List<double>();
             this.valorAct.Add(0); //por ahora el valor por defecto 
             this.valorAct.Add(0); //por ahora el valor por defecto 
             this.valorAct.Add(0); //por ahora el valor por defecto 

        }

        public Gps()
        {         
        }
        public override IList<Object> ObtenerValorActual()
        {
            IList<object> listaRet = this.valorAct.Select(o => (object)o).ToList();
            return listaRet;
        }
        public override IList<Object> ObtenerUnidades()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }
        public override IList<Object> ObtenerLimiteMaximo()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }
        public override IList<Object> ObtenerLimiteMinimo()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }

        public override IList<Object> ObtenerPrecision()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }

        public override IList<string> ObtenerParametrizacion()
        {
            IList<string> formacion = new List<string>();
            formacion.Add("Marca:tipo");
            formacion.Add("Modelo:tipo");
            formacion.Add("Unidad Eje X:String");
            formacion.Add("Máximo Eje X:Double");
            formacion.Add("Mínimo Eje X:Double");
            formacion.Add("Precision Eje X:Double");
            formacion.Add("Unidad Eje Y:String");
            formacion.Add("Máximo Eje Y:Double");
            formacion.Add("Mínimo Eje Y:Double");
            formacion.Add("Precision Eje Y:Double");
            formacion.Add("Unidad Eje Z:String");
            formacion.Add("Máximo Eje Z:Double");
            formacion.Add("Mínimo Eje Z:Double");
            formacion.Add("Precision Eje Z:Double");
            return formacion;
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            List<double> nuevoValor = new List<double>();
            nuevoValor.Add(X);
            nuevoValor.Add(Y);
            nuevoValor.Add(Z);
            
            this.valorAct = nuevoValor;
        }

        public override bool Alarmado()
        {
            return false;
        }
    }
}
