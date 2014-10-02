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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPlanVuelo ventanaAgregarP = new AgregarPlanVuelo();
            ventanaAgregarP.ShowDialog(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //agregar logica de eliminado
        }
    }
}
