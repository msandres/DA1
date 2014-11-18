using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerVelocimetro : BrokerAbstracto
    {
        public override void Guardar(OPersistente objP)
        {
            Velocimetro velo = (Velocimetro)objP;

            int oid = velo.GetOID();
            string tipo = "Velocímetro";
            string marca = velo.Marca;
            string modelo = velo.Modelo;
            int dronMedido = -1;
            try
            {
                dronMedido = velo.dronMedido.GetOID();  //arreglar el null
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
            int cantMediciones = velo.ObtenerValorActual().Count;
            while (idMedicion < cantMediciones)
            {
                string nombreVar = "Velocidad";
                string unidad = velo.ObtenerUnidades()[idMedicion].ToString().Replace(',', '.');
                string max = velo.ObtenerLimiteMaximo()[idMedicion].ToString().Replace(',', '.');
                string min = velo.ObtenerLimiteMinimo()[idMedicion].ToString().Replace(',', '.');
                string precision = velo.ObtenerPrecision()[idMedicion].ToString().Replace(',', '.');

                string insert2 = String.Format("insert into [DRONSYSTEM].[dbo].[Medicion] values({0},{1},'{2}','{3}',{4},{5},{6})", oid, idMedicion, nombreVar, unidad, max, min, precision);
                conexion.EjecutarSentencia(insert2);
                idMedicion++;
            }
        }

        public override void Modificar(OPersistente objP)
        {
            Velocimetro velo = (Velocimetro)objP;

            int oid = velo.GetOID();
            string dronMedido = "null";
            try
            {
                dronMedido = velo.dronMedido.GetOID().ToString();
            }
            catch
            {
            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }
    }
}
