﻿using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public class FabricaConcretaTermometro : IFabricaTermometro
    {
        public ComponenteAbstracto CrearDisenioTermometro(List<List<object>> parametros)
        {
            return new Termometro(parametros[0][0].ToString(), parametros[1][0].ToString(), parametros[2], parametros[3], parametros[4], parametros[5]);
        }
    }
}
