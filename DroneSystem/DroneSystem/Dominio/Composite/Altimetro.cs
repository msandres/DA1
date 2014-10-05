using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Altimetro:ComponenteAbstracto
    {

        public int AltX { get; set; }
        public int AltY { get; set; }
        public int AltZ { get; set; }

        public Altimetro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            //IdComponenteClase++;
            //this.IdComponente = IdComponenteClase;
        }

        public Altimetro()
        {         
        }

        public override IList<Object> ObtenerValorActual()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }
        
        public override IList<Object> ObtenerUnidades()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }


        public override IList<Object> ObtenerLimiteMaximo()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }
        public override IList<Object> ObtenerLimiteMinimo()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }

        public override IList<Object> ObtenerPrecision()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
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
            throw new NotImplementedException();
        }

        public override bool Alarmado()
        {
            return true;
        }
    }
}
