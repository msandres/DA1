using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Velocimetro : ComponenteAbstracto
    {

        public int VelX { get; set; }
        public int VelY { get; set; }
        public int VelZ { get; set; }

        public Velocimetro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            //IdComponenteClase++;
            //this.IdComponente = IdComponenteClase;
        }
        public Velocimetro()
        {         
        }

        public override IList<Object> ObtenerValorActual()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
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
            throw new NotImplementedException();
        }

        public override bool Alarmado()
        {
            return true;
        }

    }
}
