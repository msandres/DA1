using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerAcelerometro : BrokerAbstracto
    {
        public override void Guardar(OPersistente objP)
        {
            Acelerometro acel = (Acelerometro)objP;

            int oid = acel.GetOID();
            string tipo = "Acelerómetro";
            string marca = acel.Marca;
            string modelo = acel.Modelo;
            int dronMedido = -1;
            try
            {
                dronMedido = acel.dronMedido.GetOID();  //arreglar el null
            }
            catch
            {

            }
                        
            string insert1 = "";
            if (dronMedido < 0)
                insert1 = String.Format("insert into [DRONSYSTEM].[dbo].[ComponenteAbstacto] values ({0},'{1}','{2}','{3}',{4})", oid, tipo, marca, modelo, "null");
            else
                insert1 = String.Format("insert into [DRONSYSTEM].[dbo].[ComponenteAbstacto] values ({0},'{1}','{2}','{3}',{4})", oid, tipo, marca, modelo, dronMedido);


            conexion.EjecutarSentencia(insert1);

            int idMedicion = 0;
            int cantMediciones = acel.ObtenerValorActual().Count;
            while (idMedicion < cantMediciones)
            {
                string nombreVar = "Aceleración";
                string unidad = acel.ObtenerUnidades()[idMedicion].ToString().Replace(',', '.');
                string max = acel.ObtenerLimiteMaximo()[idMedicion].ToString().Replace(',', '.');
                string min = acel.ObtenerLimiteMinimo()[idMedicion].ToString().Replace(',', '.');
                string precision = acel.ObtenerPrecision()[idMedicion].ToString().Replace(',', '.');

                string insert2 = String.Format("insert into [DRONSYSTEM].[dbo].[Medicion] values({0},{1},'{2}','{3}',{4},{5},{6})", oid, idMedicion, nombreVar, unidad, max, min, precision);
                conexion.EjecutarSentencia(insert2);
                idMedicion++;
            }

            
        }

        public override void Modificar(OPersistente objP)
        {
            Acelerometro acel = (Acelerometro)objP;

            int oid = acel.GetOID();
            string dronMedido = "null";
            try
            {
                dronMedido = acel.dronMedido.GetOID().ToString();
            }
            catch
            {
            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }
    }
}
