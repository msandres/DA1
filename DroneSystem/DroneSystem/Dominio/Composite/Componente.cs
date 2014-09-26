using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    class Componente:ComponenteAbstracto
    {
        public IList<ComponenteAbstracto> Listacomponentes { get; set; }


        public Componente()
        {
            IdComponenteClase++;
            this.IdComponente = IdComponenteClase;
            Listacomponentes = new List<ComponenteAbstracto>();
                
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
