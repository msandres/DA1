using DroneSystem.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneSystem.Ventanas
{
    public partial class VueloReal : Form
    {
        public VueloReal()
        {
            InitializeComponent();
            Recargar();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
             int cantplanSel = dataGridPlan.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int cantdronSel = dataGridDrones.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (cantplanSel == cantdronSel && cantplanSel == 1)
            {
                int idPlan = dataGridPlan.CurrentRow.Index;
                int idDron = dataGridDrones.CurrentRow.Index;
                Fachada.GetInstancia().IniciarVuelo(idDron, idPlan);
                ControlDeVuelo vent = new ControlDeVuelo();
                Fachada.GetInstancia().AagregarObserverDron(vent);
                vent.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Plan y un Dron");
            }
        }

        private void Recargar()
        {
            dataGridDrones.Rows.Clear();
            dataGridDrones.Refresh();
            dataGridPlan.Rows.Clear();
            dataGridPlan.Refresh();

            foreach (PlanVuelo plan in Fachada.GetInstancia().GetPlanesDeVuelo())
            {
                dataGridPlan.Rows.Add(plan.GetNombre());
            }

            foreach (Dron dron in Fachada.GetInstancia().GetDrones())
            {
                dataGridDrones.Rows.Add(dron.GetNombre(), dron.GetNroSerie());
            }


            dataGridDrones.Refresh();
            dataGridPlan.Refresh();
        }
    }
}
