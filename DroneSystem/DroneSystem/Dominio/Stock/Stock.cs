﻿using DroneSystem.Dominio.Composite;
using DroneSystem.PatronesExtras.Observer;
using DroneSystem.Persistencia.Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Dominio.Stock
{
    public class Stock:Observable,IStock
    {

        private IList<PlanVuelo> listaPlanesVuelo;
        private IList<Dron> listaDrones;
        private IList<ComponenteAbstracto> listaComponentes;

        private static Stock instancia;


        private Stock()
        {
            listaPlanesVuelo = new List<PlanVuelo>();
            listaDrones = new List<Dron>();
            listaComponentes = new List<ComponenteAbstracto>();
            Observers = new List<IObserver>();
        }

        public static Stock GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Stock();
            }
            return instancia;
        }

        public void AgregarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Add(plan);
            Notify();

            BrokerAbstracto.CrearBroker(plan).Guardar(plan);
        }

        public IList<PlanVuelo> GetPlanesVuelo()
        {
            return this.listaPlanesVuelo;
        }

        public void EliminarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Remove(plan);
            Notify();
            BrokerAbstracto.CrearBroker(plan).Eliminar(plan);
        }

        public void AgregarComponente(ComponenteAbstracto comp)
        {
            listaComponentes.Add(comp);
            Notify();
           
         BrokerAbstracto.CrearBroker(comp).Guardar(comp);
            
        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return listaComponentes;
        }

        public void EliminarComponente(ComponenteAbstracto comp)
        {
            listaComponentes.Remove(comp);
        }

        public void AgregarDron(Dron dron)
        {
            listaDrones.Add(dron);
            Notify();

            BrokerAbstracto.CrearBroker(dron).Guardar(dron);
        }

        public IList<Dron> GetDrones()
        {
            return listaDrones;
        }

        public void EliminarDron(Dron dron)
        {
            listaDrones.Remove(dron);
            Notify();
            foreach (ComponenteAbstracto comp in dron.GetComponentes())
            {
                this.listaComponentes.Add(comp);
            }
            BrokerAbstracto.CrearBroker(dron).Eliminar(dron);

        }

        public override void AgregarOb(IObserver observer)
        {
            Observers.Add(observer);
        }

        public override void RemoverOb(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
