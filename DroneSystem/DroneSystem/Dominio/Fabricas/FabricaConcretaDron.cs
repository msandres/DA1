using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public class FabricaConcretaDron:IFabricaDron
    {
        public Dron CrearDisenioDron(String nombre, String color, String control,Double precio)
        {
            return new Dron(nombre, color, control,precio);
        }
    }
}
