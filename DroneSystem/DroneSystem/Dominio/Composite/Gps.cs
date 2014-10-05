﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Composite
{
    public class Gps:ComponenteAbstracto
    {

        public Gps(string marca)
        {         
        }

        public Gps()
        {         
        }
        public override IList<Object> ObtenerValorActual()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }
        public override IList<Object> ObtenerUnidades()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }
        public override IList<Object> ObtenerLimiteMaximo()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }
        public override IList<Object> ObtenerLimiteMinimo()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }

        public override IList<Object> ObtenerPrecision()
        {
            IList<Object> listavaloes = new List<Object>();
            return listavaloes;
        }

        public override IList<string> ObtenerParametrizacion()
        {
            IList<string> formacion = new List<string>();
            formacion.Add("Marca:tipo");
            formacion.Add("Modelo:tipo");
            formacion.Add("Unidad Eje X:String");
            formacion.Add("Máximo Eje X:Double");
            formacion.Add("Mínimo Eje X:Double");
            formacion.Add("Precision Eje X:Double");
            formacion.Add("Unidad Eje Y:String");
            formacion.Add("Máximo Eje Y:Double");
            formacion.Add("Mínimo Eje Y:Double");
            formacion.Add("Precision Eje Y:Double");
            formacion.Add("Unidad Eje Z:String");
            formacion.Add("Máximo Eje Z:Double");
            formacion.Add("Mínimo Eje Z:Double");
            formacion.Add("Precision Eje Z:Double");
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
