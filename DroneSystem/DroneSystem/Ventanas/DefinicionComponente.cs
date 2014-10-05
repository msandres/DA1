using DroneSystem.Dominio;
using DroneSystem.Dominio.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneSystem.Ventanas
{
    public partial class DefinicionComponente : Form
    {
        public DefinicionComponente()
        {
            InitializeComponent();
            LlenarCombo();
            dataGridDefinicion.Visible = false;
            txtBCantidad.Enabled = false;

        }

        private void LlenarCombo()
        {
            foreach (string tipo in Fachada.GetInstancia().TiposComponente())
            {
                cBTipos.Items.Add(tipo);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<object> parametrosConf = new List<object>();

            parametrosConf.Add(cBTipos.SelectedItem);

            int idRow = 0;

            while (idRow<dataGridDefinicion.Rows.Count)
            {
                int idCol = 0;
                while(idCol<dataGridDefinicion.Columns.Count)
                {
                    parametrosConf.Add(dataGridDefinicion.Rows[idRow].Cells[idCol].Value);
                    idCol++;
                }

                Fachada.GetInstancia().CrearComponente(parametrosConf);

                idRow++;
            }
            MessageBox.Show("Falta Implementar");
        }

        private void cBTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBCantidad.Enabled = true;
            string tipo = cBTipos.GetItemText(cBTipos.SelectedItem);

            ArmoGrilla(tipo, Fachada.GetInstancia().ObtenerParametros(tipo));
        }

        private void ArmoGrilla(string tipo, IList<string> datosCabezales)
        {
            dataGridDefinicion.Columns.Clear();
            int idCol = 0;
            if (datosCabezales.Count>0)
            {
                foreach (string cabezal in datosCabezales)
                {
                    string nombre = cabezal.Split(':')[0];
                    Type tipoDato = Type.GetType("System." + cabezal.Split(':')[1].ToString());
                    dataGridDefinicion.Columns.Add(nombre, nombre);
                    dataGridDefinicion.Columns[idCol].ValueType = tipoDato;
                    idCol++;
                }
                dataGridDefinicion.Visible = true;
                dataGridDefinicion.Enabled = false;
            }
            else
            {
                MessageBox.Show("No existen piezas para hacer un Complejo !!!");
            }
        }

        private void txtBCantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidadNueva;
            if (!Int32.TryParse(txtBCantidad.Text.ToString(), out cantidadNueva))
            {
                txtBCantidad.Text = "0";
                MessageBox.Show("Debe poner un entero !!!");
            }
            AgregarFilas(cantidadNueva);
        }

        private void AgregarFilas(int numeroFilas)
        {
            if (numeroFilas <= 0)
            {
                dataGridDefinicion.Rows.Clear();
                dataGridDefinicion.Enabled = false;
            }
            else
            {
                dataGridDefinicion.Rows.Add(numeroFilas);
                dataGridDefinicion.Enabled = true;
            }
            dataGridDefinicion.Refresh();
        }

        private void dataGridDefinicion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBCantidad.Enabled = false;
        }

        private void dataGridDefinicion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("El tipo de dato de la celda no es correcto !!!");
        }

    }
}
