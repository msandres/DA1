using DroneSystem.Dominio;
using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
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
    }
}
