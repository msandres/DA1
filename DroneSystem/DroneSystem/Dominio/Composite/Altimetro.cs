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

        Altimetro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            IdComponenteClase++;
            this.IdComponente = IdComponenteClase;
        }

        public override IList<Object> ObtenerValorActual()
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

        public override bool Alarmado()
        {
            return true;
        }
    }
}
