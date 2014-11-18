using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
     public class FabricaConcretaComponenteCompuesto : IFabricaComponenteCompuesto
    {
         public ComponenteCompuesto CrearDisenioCompuesto(List<List<object>> parametros)
         {
             IList<int> idComponentes = new List<int>();
             
             int idOID=0;

             while (idOID < parametros[2].Count)
             {
                 idComponentes.Add(int.Parse(parametros[2][idOID].ToString()));
                 idOID += 3;
             }

             return new ComponenteCompuesto(parametros[0][0].ToString(), parametros[1][0].ToString(),idComponentes);//, parametros[2], parametros[3], parametros[4], parametros[5]);
         }
    }
}
