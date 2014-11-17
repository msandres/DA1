using DroneSystem.IPersistenciaPack;
using DroneSystem.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia.Broker
{
    public abstract class BrokerAbstracto 
    {
        protected ConexBD conexion;

        //public BrokerAbstracto()
        //{
        //}

        public static BrokerAbstracto CrearBroker(OPersistente objP)
        {
            BrokerAbstracto BrokerRetorno = null;
            string tipoObjeto = objP.GetType().ToString().Split('.')[objP.GetType().ToString().Split('.').Length - 1];

            switch (tipoObjeto)
            {
                case "Acelerometro": BrokerRetorno = new BrokerAcelerometro();
                    break;
                case "Altimetro": BrokerRetorno = new BrokerAltimetro();
                    break;
                case "Barometro": BrokerRetorno = new BrokerBarometro();
                    break;
                case "Componente Compuesto": BrokerRetorno = new BrokerComponente();
                    break;
                case "Gps": BrokerRetorno = new BrokerGps();
                    break;
                case "Termometro": BrokerRetorno = new BrokerTermometro();
                    break;
                case "Velocimetro": BrokerRetorno = new BrokerVelocimetro();
                    break;
                case "PlanVuelo": BrokerRetorno = new BrokerPlanVuelo();
                    break;
                case "Dron": BrokerRetorno = new BrokerDron();
                    break;
            }

            BrokerRetorno.conexion = ConexBD.GetInstancia();
            return BrokerRetorno;

        }

        public virtual void  Guardar(OPersistente objP)
        {}

        public virtual void Modificar(OPersistente objP)
        { }

        public virtual void Eliminar(OPersistente objP)
        { }
        public virtual DataTable Cargar()
        {
            DataTable retorno = new DataTable();
            return retorno;
        }
    }
}
