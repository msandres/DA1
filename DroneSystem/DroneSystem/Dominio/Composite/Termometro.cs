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

        public Termometro(string marca, string modelo, IList<object> unidades, IList<object> max, IList<object> min, IList<object> precision)
        {
            this.OID = SiguienteOID();
            AumentarOID();
            this.Marca = marca;
            this.Modelo = modelo;
            this.unidadesTemp = unidades.Select(s => (string)s).ToList();
            this.valorMax = max.Select(s => (double)s).ToList();
            this.valorMin = min.Select(s => (double)s).ToList(); 
            this.valorPrecision = precision.Select(s => (double)s).ToList();

            this.valorTemp = new List<double>();
            this.valorTemp.Add(23); //por ahora el valor por defecto del term es 23
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
            double valor = 23 - (Z/50); //obtengo el valor actual, cada 50 metros bajo un grado
            nuevoValor.Add(valor);
            this.valorTemp = nuevoValor;

            if (valorTemp[0] > valorMax[0] || valorTemp[0] < valorMin[0])
            {
                this.alarmado = true;
                this.tiempoAlarmado += 1;

            }
            else
            {
                this.alarmado = false;
                this.tiempoAlarmado = 0;
            }
            if (this.tiempoAlarmado > 5)
            {
                this.destruido = true;
                this.dronMedido.Destruir();
            }
        }

        public override bool Alarmado()
        {
            return this.alarmado;
        }
    }
}
