using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.IPersistenciaPack
{
    public abstract class OPersistente
    {
        protected static int UltimoOID;
        protected int OID;

        public static int SiguienteOID()
        {
            return UltimoOID + 1;
        }

        public static void AumentarOID()
        {
            UltimoOID += 1;
        }

        public int GetOID()
        {
            return this.OID;
        }

        public void Guardarse()
        {
          
        }

        public void Cargarse()
        { 
        }
    }
}
