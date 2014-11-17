using DroneSystem.Dominio;
using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia.Broker
{
    public class BrokerPlanVuelo : BrokerAbstracto
    {
        public override void Guardar(OPersistente objP)
        {
            PlanVuelo plan = (PlanVuelo)objP;

            int oid = plan.GetOID();
            string nombre = plan.GetNombre();
            double velX = plan.GetVelocidadX();
            double velY = plan.GetVelocidadY();
            double velZ = plan.GetVelocidadZ();


            string insertPlan = String.Format("insert into [DRONSYSTEM].[dbo].[PlanVuelo] values({0},'{1}','{2}','{3}',{4})", oid, nombre, velX,velY,velZ);
            conexion.EjecutarSentencia(insertPlan);
  
            int idRecorrido = 0;

            while (idRecorrido<plan.GetRecorridoX().Count)
            {
                string insertRecorrido = String.Format("insert into [DRONSYSTEM].[dbo].[Recorrido] values({0},{1},'{2}','{3}',{4})", oid, idRecorrido, plan.GetRecorridoX()[idRecorrido], plan.GetRecorridoY()[idRecorrido], plan.GetRecorridoZ()[idRecorrido]);
                conexion.EjecutarSentencia(insertRecorrido);
                idRecorrido++;
            }
        }

        public override void Eliminar(OPersistente objP)
        {
            PlanVuelo plan = (PlanVuelo)objP;

            int oid = plan.GetOID();

            string deletePlan = " delete FROM [DRONSYSTEM].[dbo].[PlanVuelo] where idPlan=" + oid;
            conexion.EjecutarSentencia(deletePlan);

        }

        public override DataTable Cargar()
        {
            string consulta = " SELECT P.idPlan,P.Nombre,P.VelocidadX,P.VelocidadY,P.VelocidadZ,R.coorX,R.coorY,R.coorZ  FROM [DRONSYSTEM].[dbo].[PlanVuelo] P , [DRONSYSTEM].[dbo].[Recorrido] R " +
                            " where P.idPlan = R.idPlan order by P.idPlan,idRec ";

            DataTable planes = conexion.TraerDatos(consulta);

            return planes;
        }
    }
}
