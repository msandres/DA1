using DroneSystem.Dominio;
using DroneSystem.Dominio.Composite;
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
    public partial class DiseniosDisponibles : Form,IObserver
    {
        public DiseniosDisponibles()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            dataGridDisDron.Rows.Clear();
            dataGridDisDron.Refresh();
            dataGridDisComp.Rows.Clear();
            dataGridDisComp.Refresh();

            foreach (ComponenteAbstracto compAbs in Fachada.GetInstancia().GetComponentes())
            {
                dataGridDisComp.Rows.Add(compAbs.Marca,compAbs.Modelo);
            }

            //foreach (PlanVuelo plan in Fachada.GetInstancia().GetPlanesDeVuelo())
            //{
            //    datagridPlanes.Rows.Add(plan.GetNombre());
            //}

            dataGridDisDron.Refresh();
            dataGridDisComp.Refresh();

        }

        private void btnCerrarDisponibles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAgregarDisDron_Click(object sender, EventArgs e)
        {
            AgregarFilasDataGrid(dataGridDisDron);
        }

        private void btnModifDisDron_Click(object sender, EventArgs e)
        {

        }

        private void btnElimDisDron_Click(object sender, EventArgs e)
        {
            EliminarFilasDataGrid(dataGridDisDron);
 
        }

        private void btnAgregarDisComp_Click(object sender, EventArgs e)
        {
            Fachada.GetInstancia().AagregarObserverStock(this); 

            DefinicionComponente vent = new DefinicionComponente();
            vent.ShowDialog(this);

            Fachada.GetInstancia().RemoverObserverStock(this); 
  

        }

        private void btnModifDisComp_Click(object sender, EventArgs e)
        {

        }

        private void btnElimDisComp_Click(object sender, EventArgs e)
        {
            EliminarFilasDataGrid(dataGridDisComp);
        }


        //le paso un datagridview y le agrego registros
        private void AgregarFilasDataGrid(DataGridView dataGridDisp)
        {
            //acá se toma el nuevo dron y se asigna los valores al nuevo registro
            DataGridViewRow nuevoRegistro = new DataGridViewRow();
            dataGridDisp.Rows.Add(nuevoRegistro);
            dataGridDisp.Refresh();
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
               foreach (int id in seleccion)
                {
                    dataGridDisp.Rows.RemoveAt(id);
                    dataGridDisp.Refresh();
                }
            }
        }
    }
}
