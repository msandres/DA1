using DroneSystem.IPersistenciaPack;
using DroneSystem.Persistencia;
using System;
using System.Collections.Generic;
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
            if (objP.GetType().ToString().Contains("Termometro")) 
            {
                BrokerRetorno = new BrokerTermometro();
                BrokerRetorno.conexion = ConexBD.GetInstancia();
            }

            return BrokerRetorno;
        }

        public virtual void Guardar(OPersistente objP)
        {
 
        }
    }
}
