using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerDron : BrokerAbstracto
    {
        public override void Guardar(OPersistente objP)
        {
            Dron dron = (Dron)objP;

            int oid = dron.GetOID();
            int nroSerie = dron.GetNroSerie();
            string nombre = dron.GetNombre();
            string color = dron.GetColor();
            string control = dron.GetControlRemoto();
            double precio = dron.GetPrecio();
            int funcionamiento = dron.Funciona().GetHashCode();


            string insertDron = String.Format("insert into [DRONSYSTEM].[dbo].[Dron] values({0},{1},'{2}','{3}','{4}',{5},{6})", 
                                            oid,nroSerie, nombre, color, control, precio,funcionamiento);
            conexion.EjecutarSentencia(insertDron);
        }
    }
}
