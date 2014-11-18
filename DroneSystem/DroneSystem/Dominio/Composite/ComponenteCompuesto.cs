using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class ComponenteCompuesto:ComponenteAbstracto
    {
        private IList<ComponenteAbstracto> listacomponentes;


        public ComponenteCompuesto(string marca, string modelo, IList<int> idComponentes)
        {
            this.OID = SiguienteOID();
            AumentarOID();

            this.Marca = marca;
            this.Modelo = modelo;

            listacomponentes = new List<ComponenteAbstracto>();

            IList<ComponenteAbstracto> comps = Fachada.GetInstancia().GetComponentes();
            int idComp = 0;
            int cantComp = comps.Count;
            while (idComp < cantComp)
            {
                bool restar = false;
                foreach (int compCompuesto in idComponentes)
                {
                    
                    if (!restar && comps[idComp].GetOID() == compCompuesto)
                    {
                        listacomponentes.Add(comps[idComp]);
                        Fachada.GetInstancia().GetComponentes().RemoveAt(idComp);
                        cantComp--;
                        restar = true;
                    }

                }
                if (restar)
                    idComp--;

                idComp++;
            }

            ResetarValores();
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

        public override void ResetarValores()
        {
           foreach (ComponenteAbstracto comp in listacomponentes)
           {
               comp.ResetarValores();
           }
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            foreach (ComponenteAbstracto componente in listacomponentes)
            {
                componente.SetValor(X, Y, Z);
            }
        }

        public override void Alarmar() //Alarma el sensor en caso de que la medición actual pase los umbrales max y min
        {
            if (this.tiempoAlarmado > 5)
            {
                this.destruido = true;
                this.dronMedido.Destruir();
            }
            else
            {
                int largoListaValores = this.GetComponentes().Count;
                int idLista = 0;
                bool dioAlarma = false;
                while (!dioAlarma && idLista < largoListaValores)   //recorro las variables medidas a ver si alguna está alarmada
                {
                    dioAlarma = this.GetComponentes()[idLista].Alarmado();
                    idLista++;
                }

                if (dioAlarma)  //si alguna alarmó, marco como alarmado
                {
                    this.alarmado = true;
                    this.tiempoAlarmado += 1;
                }
                else
                {
                    this.alarmado = false;
                    this.tiempoAlarmado = 0;
                }
            }
        }
    }
}
