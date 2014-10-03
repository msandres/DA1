using DroneSystem.Dominio;
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
    public partial class Principal : Form
    {

        private static Principal instancia = null;  //Singleton

        private List<PlanVuelo> listaPlanesVuelo = new List<PlanVuelo>();

        private Timer timeSec = new Timer();

        private Principal()
        {
            InitializeComponent();
            timeSec.Enabled = true;
            timeSec.Interval = 1000;
            timeSec.Tick += new EventHandler(AccionTemporal);
        }

        public static Principal GetInstancia()
        {
            if (instancia == null)
                instancia = new Principal();
            return instancia;
        }

        public void AgregarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Add(plan);
        }

        public void EliminarPlanVuelo(PlanVuelo plan)
        {
            listaPlanesVuelo.Remove(plan);
        }

        public List<PlanVuelo> GetPlanesVuelo()
        {
            return this.listaPlanesVuelo;
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
            MessageBox.Show("Desarrollado por: \n\n Andrés Martínez (168474) \n Daniel Ferrari (?????)", "DronSystem - Obligatorio Diseño de Aplicaciones 2014");
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


    }
}
