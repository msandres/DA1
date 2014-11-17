using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia.Broker
{
    class BrokerAltimetro : BrokerAbstracto
    {

        public override void Guardar(OPersistente objP)
        {
            Altimetro altim = (Altimetro)objP;

            int oid = altim.GetOID();
            string tipo = "Altímetro";
            string marca = altim.Marca;
            string modelo = altim.Modelo;
            int dronMedido = -1;
            try
            {
                dronMedido = altim.dronMedido.GetOID();  //arreglar el null
            }
            catch
            {

            }

            string nombreVar = "Altura";
            string unidad = altim.ObtenerUnidades()[0].ToString().Replace(',', '.');
            string max = altim.ObtenerLimiteMaximo()[0].ToString().Replace(',', '.');
            string min = altim.ObtenerLimiteMinimo()[0].ToString().Replace(',', '.');
            string precision = altim.ObtenerPrecision()[0].ToString().Replace(',', '.');

           
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
            Altimetro altim = (Altimetro)objP;

            int oid = altim.GetOID();
            int dronMedido = -1;
            try
            {
                dronMedido = altim.dronMedido.GetOID();  
            }
            catch
            {

            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }

    }
}
