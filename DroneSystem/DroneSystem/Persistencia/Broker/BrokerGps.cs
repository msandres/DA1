using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerGps : BrokerAbstracto
    {
        public override void Guardar(OPersistente objP)
        {
            Gps GPS = (Gps)objP;

            int oid = GPS.GetOID();
            string tipo = "GPS";
            string marca = GPS.Marca;
            string modelo = GPS.Modelo;
            int dronMedido = -1;
            try
            {
                dronMedido = GPS.dronMedido.GetOID();  //arreglar el null
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
            int cantMediciones = GPS.ObtenerValorActual().Count;
            while (idMedicion < cantMediciones)
            {
                string nombreVar = "Posición";
                string unidad = GPS.ObtenerUnidades()[idMedicion].ToString().Replace(',', '.');
                string max = GPS.ObtenerLimiteMaximo()[idMedicion].ToString().Replace(',', '.');
                string min = GPS.ObtenerLimiteMinimo()[idMedicion].ToString().Replace(',', '.');
                string precision = GPS.ObtenerPrecision()[idMedicion].ToString().Replace(',', '.');

                string insert2 = String.Format("insert into [DRONSYSTEM].[dbo].[Medicion] values({0},{1},'{2}','{3}',{4},{5},{6})", oid, idMedicion, nombreVar, unidad, max, min, precision);
                conexion.EjecutarSentencia(insert2);
                idMedicion++;
            }
        }

        public override void Modificar(OPersistente objP)
        {
            Gps GPS = (Gps)objP;

            int oid = GPS.GetOID();
            string dronMedido = "null";
            try
            {
                dronMedido = GPS.dronMedido.GetOID().ToString();
            }
            catch
            {
            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }
    }
}
