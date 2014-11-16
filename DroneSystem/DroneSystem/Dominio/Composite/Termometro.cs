using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Termometro:ComponenteAbstracto
    {
        public Termometro(string marca, string modelo, IList<object> unidades, IList<object> max, IList<object> min, IList<object> precision)
        {
            this.OID = SiguienteOID();
            AumentarOID();
            this.Marca = marca;
            this.Modelo = modelo;
            this.unidades = unidades.Select(s => (string)s).ToList();
            this.valorMax = max.Select(s => (double)s).ToList();
            this.valorMin = min.Select(s => (double)s).ToList(); 
            this.valorPrecision = precision.Select(s => (double)s).ToList();

            ResetarValores();
         }

        public Termometro()
        { 

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

        public override void ResetarValores()
        {
            this.valor = new List<double>();
            this.valor.Add(23); //por ahora el valor por defecto del term es 23
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            List<double> nuevoValor = new List<double>();
            double valorCalc = 23 - (Z/50); //obtengo el valor actual, cada 50 metros bajo un grado
            nuevoValor.Add(valorCalc);
            this.valor = nuevoValor;

            if (this.valor[0] > valorMax[0] || this.valor[0] < valorMin[0])
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
    }
}
