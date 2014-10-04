using DroneSystem.Dominio;
using DroneSystem.PatronesExtras.Observer;
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
    public partial class PlanesDisponibles : Form, IObserver
    {
        public PlanesDisponibles()
        {
            InitializeComponent();
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Fachada.GetInstancia().AagregarObserverStock(this);
            
            AgregarPlanVuelo ventanaAgregarP = new AgregarPlanVuelo();
            ventanaAgregarP.ShowDialog(this);

            Fachada.GetInstancia().RemoverObserverStock(this);

        }

        public void Actualizar()
        {
            datagridPlanes.Rows.Clear();
            datagridPlanes.Refresh();
            foreach (PlanVuelo plan in Fachada.GetInstancia().GetPlanesDeVuelo())
            {
                datagridPlanes.Rows.Add(plan.GetNombre());
            }

            datagridPlanes.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFilasDataGrid(datagridPlanes);
        }

        //le paso un datagridview y elimino los registros seleccionados
        private void EliminarFilasDataGrid(DataGridView dataGridDisp)
        {
            int seleccionados = dataGridDisp.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (seleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fila completa !!!");
            }
            else
            {
                List<int> seleccion = new List<int>();
                int idDGV = 0;
                int cantSeleccionados = 0;
                while (idDGV < dataGridDisp.Rows.Count)
                {

                    if (dataGridDisp.Rows.GetRowState(idDGV).ToString().Contains("Selected"))
                    {
                        seleccion.Add(idDGV - cantSeleccionados);
                        cantSeleccionados++;
                    }
                    idDGV++;
                }

                Fachada.GetInstancia().AagregarObserverStock(this);

                foreach (int id in seleccion)
                {
                    Fachada.GetInstancia().EliminarPlanDeVuelo(Fachada.GetInstancia().GetPlanesDeVuelo()[id]);
                }

                Fachada.GetInstancia().RemoverObserverStock(this);
            }
        }
    }
}
