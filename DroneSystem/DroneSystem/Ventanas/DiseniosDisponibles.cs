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
    public partial class DiseniosDisponibles : Form
    {
        public DiseniosDisponibles()
        {
            InitializeComponent();
        }

        private void btnCerrarDisponibles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAgregarDisDron_Click(object sender, EventArgs e)
        {

        }

        private void btnModifDisDron_Click(object sender, EventArgs e)
        {

        }

        private void btnElimDisDron_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection seleccionados =  dataGridDisDron.SelectedRows;

            if (seleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fila completa !!!");
            }
            else 
            {

            }
 
        }

        private void btnAgregarDisComp_Click(object sender, EventArgs e)
        {

        }

        private void btnModifDisComp_Click(object sender, EventArgs e)
        {

        }

        private void btnElimDisComp_Click(object sender, EventArgs e)
        {

        }
    }
}
