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
    public partial class PlanesDisponibles : Form
    {
        public PlanesDisponibles()
        {
            InitializeComponent();
            RecargarListadePlanes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPlanVuelo ventanaAgregarP = new AgregarPlanVuelo();
            ventanaAgregarP.ShowDialog(this);
            RecargarListadePlanes();
        }

        private void RecargarListadePlanes()
        {
            datagridPlanes.Rows.Clear();
            datagridPlanes.Refresh();
            Principal p = Principal.GetInstancia();
            foreach (PlanVuelo plan in p.GetPlanesVuelo())
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
            RecargarListadePlanes();
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

                Principal p = Principal.GetInstancia();
                foreach (int id in seleccion)
                {
                    p.EliminarPlanVuelo(p.GetPlanesVuelo()[id]);
                }
            }
        }
    }
}
