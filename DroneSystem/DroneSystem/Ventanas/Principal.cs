﻿using DroneSystem.Dominio;
using DroneSystem.Dominio.Composite;
using DroneSystem.Dominio.Persistencia;
using DroneSystem.PatronesExtras.Observer;
using DroneSystem.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DroneSystem
{
    public partial class Principal : Form,IObserver
    {

        private Timer timeSec = new Timer();

        public Principal()
        {
            InitializeComponent();
            Fachada.GetInstancia().AagregarObserverStock(this);
            timeSec.Enabled = true;
            timeSec.Interval = 1000;
            timeSec.Tick += new EventHandler(AccionTemporal);
            CargaDatosBaseSQL baseP = new CargaDatosBaseSQL();
            baseP.Cargar();
        }

        public void Actualizar()
        {
            dataGridDrones.Rows.Clear();
            dataGridDrones.Refresh();
            dataGridComponentes.Rows.Clear();
            dataGridComponentes.Refresh();

            foreach (ComponenteAbstracto compAbs in Fachada.GetInstancia().GetComponentes())
            {
                dataGridComponentes.Rows.Add(compAbs.Marca, compAbs.Modelo);
            }

            foreach (Dron dron in Fachada.GetInstancia().GetDrones())
            {
                dataGridDrones.Rows.Add(dron.GetNombre(), dron.GetNroSerie());
            }

            dataGridDrones.Refresh();
            dataGridComponentes.Refresh();
        }


        private void AccionTemporal(Object myObject,
                                            EventArgs myEventArgs)
        {
            string hora = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second.ToString();
            reloj.Text = hora;
        }

        private void MArchivoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MAyudaAcerdaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: \n\n Andrés Martínez (168474) \n Daniel Ferrari (161390)", "DronSystem - Obligatorio Diseño de Aplicaciones 2014");
        }

        private void diseñosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiseniosDisponibles ventanaDiseño = new DiseniosDisponibles();
            ventanaDiseño.ShowDialog(this);
        }

        private void modelosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelosDisponibles ventanaModelo = new ModelosDisponibles();
            ventanaModelo.ShowDialog(this);
        }

        private void planesDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanesDisponibles ventanaPlanesDisp = new PlanesDisponibles();
            ventanaPlanesDisp.ShowDialog(this);
        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICargaDatos cargaD = new CargaDatosManual();
            cargaD.Cargar();
        }

        private void realToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VueloReal vent = new VueloReal();
            vent.ShowDialog(this);
        }


    }
}
