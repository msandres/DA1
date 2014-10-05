using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Termometro:ComponenteAbstracto
    {
        private IList<double> valorTemp;
        private IList<string> unidadesTemp;
        private IList<double> valorMax;
        private IList<double> valorMin;
        private IList<double> valorPrecision;

        public Termometro(string marca,string modelo,IList<string> unidades,IList<double> max,IList<double> min, IList<double> precision)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.unidadesTemp = unidades;
            this.valorMax = max;
            this.valorMin = min;
            this.valorPrecision = precision;

         }

        public Termometro()
        { 

        }

        public override IList<Object> ObtenerValorActual()
        {
            IList<object> listaRet = this.valorTemp.Select(o => (object)o).ToList();
            return listaRet;
        }

        public override IList<Object> ObtenerUnidades()
        {
            IList<object> listaRet = this.unidadesTemp.Select(o => (object)o).ToList();
            return listaRet;
        }

        public override IList<Object> ObtenerLimiteMaximo()
        {
            IList<object> listaRet = this.valorMax.Select(o => (object)o).ToList();
            return listaRet;
        }
        public override IList<Object> ObtenerLimiteMinimo()
        {
            IList<object> listaRet = this.valorMin.Select(o => (object)o).ToList();
            return listaRet;
        }

        public override IList<Object> ObtenerPrecision()
        {
            IList<object> listaRet = this.valorPrecision.Select(o => (object)o).ToList();
            return listaRet;
        }

        public override IList<string> ObtenerParametrizacion()
        {
            IList<string> formacion = new List<string>();

            formacion.Add("Marca:tipo");
            formacion.Add("Modelo:tipo");
            formacion.Add("Unidad:String");
            formacion.Add("Máximo:Double");
            formacion.Add("Mínimo:Double");
            formacion.Add("Precision:Double");

            return formacion;
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            List<double> nuevoValor = new List<double>();
            double valor = (double)ObtenerValorActual()[0] - (Z/3); //obtengo el valor actual y le resto un tercio de Z, es decir cada 3 metros bajo un grado
            nuevoValor.Add(valor);
            this.valorTemp = nuevoValor;

        }

        public override bool Alarmado()
        {
            return true;
        }
    }
}
