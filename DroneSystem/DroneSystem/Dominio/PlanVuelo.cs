using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio
{
    public class PlanVuelo : OPersistente, IComparable
    {
        private string nombre;

        private List<double> recorridoX;
        private List<double> recorridoY;
        private List<double> recorridoZ;

        private double velocidadX;
        private double velocidadY;
        private double velocidadZ;

        public PlanVuelo(string nombrePlan ,List<double> recX,List<double> recY,List<double> recZ,
            double velX, double velY, double velZ)
        {

            this.OID = SiguienteOID();
            AumentarOID();

            this.nombre = nombrePlan;

            this.recorridoX = recX;
            this.recorridoY = recY;
            this.recorridoZ = recZ;

            this.velocidadX = velX;
            this.velocidadY = velY;
            this.velocidadZ = velZ;

        }

        public PlanVuelo()
        { 

        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public List<double> GetRecorridoX()
        {
            return this.recorridoX;
        }

        public List<double> GetRecorridoY()
        {
            return this.recorridoY;
        }

        public List<double> GetRecorridoZ()
        {
            return this.recorridoZ;
        }

        public double GetVelocidadX()
        {
            return this.velocidadX;
        }

        public double GetVelocidadY()
        {
            return this.velocidadY;
        }

        public double GetVelocidadZ()
        {
            return this.velocidadZ;
        }

        public override bool Equals(object obj)
        {
            return this.nombre.Equals(((PlanVuelo)obj).nombre);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (this == obj) 
                return 0;
            else
                return this.nombre.CompareTo(((PlanVuelo)obj).nombre);            
        }

    }
}
