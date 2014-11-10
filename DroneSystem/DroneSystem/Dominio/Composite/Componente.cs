using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Componente:ComponenteAbstracto
    {
        private IList<ComponenteAbstracto> listacomponentes;


        public Componente()
        {
            //IdComponenteClase++;
            //this.IdComponente = IdComponenteClase;
            listacomponentes = new List<ComponenteAbstracto>();
        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return this.listacomponentes;
        }

        public void AgregarComponente(ComponenteAbstracto cmp)
        {
            this.listacomponentes.Add(cmp);
        }

        public override IList<Object> ObtenerValorActual()
        {
            IList<Object> listavalores = new List<Object>();
            foreach (ComponenteAbstracto cmp in listacomponentes)
            {
                foreach (var valor in cmp.ObtenerValorActual())
                {
                    listavalores.Add(valor);
                }
            }
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
