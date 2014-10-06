﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Barometro:ComponenteAbstracto
    {

        public Barometro(String marca)
        {
        }

        public Barometro()
        {         
        }

        public override IList<Object> ObtenerValorActual()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }

        public override IList<Object> ObtenerUnidades()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }
        public override IList<Object> ObtenerLimiteMaximo()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }
        public override IList<Object> ObtenerLimiteMinimo()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }

        public override IList<Object> ObtenerPrecision()
        {
            IList<Object> listavalores = new List<Object>();
            return listavalores;
        }

        public override IList<string> ObtenerParametrizacion()
        {
            IList<string> formacion = new List<string>();
            formacion.Add("Marca:tipo");
            formacion.Add("Modelo:tipo");
            formacion.Add("Unidad:String");
            formacion.Add("Máximo:Double");
            formacion.Add("Mínimo:Double");
            formacion.Add("Precision:Double");
            return formacion;
        }

        protected override void CalcularValor(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public override bool Alarmado()
        {
            return true;
        }
    }
}
