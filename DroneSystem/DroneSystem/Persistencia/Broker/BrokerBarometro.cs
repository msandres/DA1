using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;

namespace DroneSystem.Persistencia.Broker
{
    class BrokerBarometro : BrokerAbstracto
    {

        public override void Guardar(OPersistente objP)
        {
            Barometro baro = (Barometro)objP;

            int oid = baro.GetOID();
            string tipo = "Barómetro";
            string marca = baro.Marca;
            string modelo = baro.Modelo;
            int dronMedido = -1;
            try
            {
                dronMedido = baro.dronMedido.GetOID();  //arreglar el null
            }
            catch
            {

            }

            string nombreVar = "Presión";
            string unidad = baro.ObtenerUnidades()[0].ToString().Replace(',', '.');
            string max = baro.ObtenerLimiteMaximo()[0].ToString().Replace(',', '.');
            string min = baro.ObtenerLimiteMinimo()[0].ToString().Replace(',', '.');
            string precision = baro.ObtenerPrecision()[0].ToString().Replace(',', '.');


            string insert1 = "";
            if (dronMedido < 0)
                insert1 = String.Format("insert into [DRONSYSTEM].[dbo].[ComponenteAbstacto] values ({0},'{1}','{2}','{3}',{4})", oid, tipo, marca, modelo, "null");
            else
                insert1 = String.Format("insert into [DRONSYSTEM].[dbo].[ComponenteAbstacto] values ({0},'{1}','{2}','{3}',{4})", oid, tipo, marca, modelo, dronMedido);
            string insert2 = String.Format("insert into [DRONSYSTEM].[dbo].[Medicion] values({0},{1},'{2}','{3}',{4},{5},{6})", oid, 1, nombreVar, unidad, max, min, precision);

            //conexion = ConexBD.GetInstancia();
            conexion.EjecutarSentencia(insert1);
            conexion.EjecutarSentencia(insert2);

        }

        public override void Modificar(OPersistente objP)
        {
            Barometro baro = (Barometro)objP;

            int oid = baro.GetOID();
            int dronMedido = -1;
            try
            {
                dronMedido = baro.dronMedido.GetOID();
            }
            catch
            {

            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }
    }
}
