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

        Velocimetro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            //IdComponenteClase++;
            //this.IdComponente = IdComponenteClase;
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
