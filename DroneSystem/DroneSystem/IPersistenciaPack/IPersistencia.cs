using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.IPersistenciaPack
{
    interface IPersistencia
    {
        void Guardar(OPersistente objP);
        void Cargar(OPersistente objP); 
    }
}
