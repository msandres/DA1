﻿using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public interface IFabricaBarometro
    {
        ComponenteAbstracto CrearDisenioBarometro(List<List<object>> parametros);
    }
}
