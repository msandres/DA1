using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public class FabricaConcretaDron:IFabricaDron
    {
        public Dron CrearDisenioDron()
        {
            return new Dron("a", "b", "c");
        }
    }
}
