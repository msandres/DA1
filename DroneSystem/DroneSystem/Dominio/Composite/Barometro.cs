using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Barometro:ComponenteAbstracto
    {
        public Barometro(string marca, string modelo, IList<object> unidades, IList<object> max, IList<object> min, IList<object> precision)
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

        public Barometro()
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
            this.valor.Add(1000); //por ahora el valor por defecto es 1000
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            List<double> nuevoValor = new List<double>();
            double valorCalc = 1000 - (Z*(200 / 4000))*1.2; //obtengo el valor actual, una paorximación al calculo de presion atmosférica 
            nuevoValor.Add(valorCalc);
            this.valor = nuevoValor;
        }

    }
}
