using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Gps:ComponenteAbstracto
    {
        public Gps(string marca, string modelo, IList<object> unidades, IList<object> max, IList<object> min, IList<object> precision)
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

        public Gps()
        {         
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

       public override void ResetarValores()
       {
           this.valor = new List<double>();
           this.valor.Add(0); //por ahora el valor por defecto es 0
           this.valor.Add(0); //por ahora el valor por defecto es 0 
           this.valor.Add(0); //por ahora el valor por defecto es 0
       }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            List<double> nuevoValor = new List<double>();
            nuevoValor.Add(X);
            nuevoValor.Add(Y);
            nuevoValor.Add(Z);
            
            this.valor = nuevoValor;
        }

    }
}
