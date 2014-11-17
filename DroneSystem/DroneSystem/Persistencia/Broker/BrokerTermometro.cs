using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerTermometro : BrokerAbstracto
    {

        public override void Guardar(OPersistente objP)
        {
            Termometro term = (Termometro)objP;

             int oid = term.GetOID();
             string tipo = "Termómetro";
             string marca = term.Marca;
             string modelo = term.Modelo;
             int dronMedido = -1;
             try
             {
                 dronMedido = term.dronMedido.GetOID();  //arreglar el null
             }
             catch
             { 

             }

             string nombreVar = "Temperatura";
             string unidad = term.ObtenerUnidades()[0].ToString().Replace(',', '.');
             string max = term.ObtenerLimiteMaximo()[0].ToString().Replace(',','.');
             string min = term.ObtenerLimiteMinimo()[0].ToString().Replace(',', '.');
             string precision = term.ObtenerPrecision()[0].ToString().Replace(',', '.');

            //SELECT TOP 1000 [OID]
            //,[Tipo]
            //,[Marca]
            //,[Modelo]
            //,[DronMedido]
            //FROM [DRONSYSTEM].[dbo].[ComponenteAbstacto]

            // SELECT TOP 1000 [OIDComponente]
            //,[idMedicion]
            //,[NombreVariable]
            //,[Unidad]
            //,[Maximo]
            //,[Minimo]
            //,[Precision]
            //FROM [DRONSYSTEM].[dbo].[Medicion]


            //insert into [DRONSYSTEM].[dbo].[ComponenteAbstacto] values (1,'Termómetro','MarcaTerm','ModeloTErm',null)
            //insert into [DRONSYSTEM].[dbo].[Medicion] values(1,1,'Temperatura','°C',50,-50,1)
             string insert1 = "";
            if (dronMedido<0)
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
            Termometro term = (Termometro)objP;

            int oid = term.GetOID();
            string  dronMedido = "null";
            try
            {
                dronMedido = term.dronMedido.GetOID().ToString(); 
            }
            catch
            {
            }
            string updateComp = "update [DRONSYSTEM].[dbo].[ComponenteAbstacto] set DronMedido=" + dronMedido + " where OID=" + oid;
            conexion.EjecutarSentencia(updateComp);
        }

    }
}
