﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Fabricas
{
    public interface IFabricaDron
    {
        Dron CrearDisenioDron(String nombre, String color, String control,Double precio);
    }
}
