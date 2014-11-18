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

            OcultarMarcaModelo();
        }

        private void OcultarMarcaModelo()
        {
            lblMarca.Visible = false;
            lblModelo.Visible = false;
            txtBMarca.Visible = false;
            txtBModelo.Visible = false;
        }

        private void MostrarMarcaModelo()
        {
            lblMarca.Visible = true;
            lblModelo.Visible = true;
            txtBMarca.Visible = true;
            txtBModelo.Visible = true;
            
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
            if (!txtBMarca.Enabled)
            {

                List<object> parametrosConf = new List<object>();

                parametrosConf.Add(cBTipos.SelectedItem);

                if (txtBMarca.Enabled)
                {
                    parametrosConf.Add(txtBMarca.Text);
                    parametrosConf.Add(txtBModelo.Text);
                }

                int idRow = 0;

                while (idRow < dataGridDefinicion.Rows.Count)
                {
                    int idCol = 0;
                    while (idCol < dataGridDefinicion.Columns.Count)
                    {
                        parametrosConf.Add(dataGridDefinicion.Rows[idRow].Cells[idCol].Value);
                        idCol++;
                    }

                    Fachada.GetInstancia().CrearComponente(parametrosConf);

                    parametrosConf = new List<object>();

                    parametrosConf.Add(cBTipos.SelectedItem);

                    idRow++;
                }
                MessageBox.Show("Se agregó componente");
                this.Close();
            }
            else
            { 
                 List<object> parametrosConf = new List<object>();

                parametrosConf.Add(cBTipos.SelectedItem);

                    parametrosConf.Add(txtBMarca.Text);
                    parametrosConf.Add(txtBModelo.Text);
               

                int idRow = 0;

                while (idRow < dataGridDefinicion.Rows.Count)
                {
                    int idCol = 0;
                    while (idCol < dataGridDefinicion.Columns.Count)
                    {
                        parametrosConf.Add(dataGridDefinicion.Rows[idRow].Cells[idCol].Value);
                        idCol++;
                    }
                    idRow++;
                    }
                    Fachada.GetInstancia().CrearComponente(parametrosConf);

                 
                
                MessageBox.Show("Se agregó componente");
                this.Close();
            }
            
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
                if (cBTipos.SelectedItem.ToString().Contains("Componente"))
                {
                    dataGridDefinicion.Columns.Add("OID", "OID");
                    dataGridDefinicion.Columns.Add("Marca", "Marca");
                    dataGridDefinicion.Columns.Add("Modelo", "Modelo");

                    MostrarMarcaModelo();
                    txtBCantidad.Text = "1";
                    txtBCantidad.Enabled = false;

                    foreach (string cabezal in datosCabezales)
                    {
                        string oid = cabezal.Split(':')[0];
                        string marca = cabezal.Split(':')[1];
                        string modelo = cabezal.Split(':')[2];
                        dataGridDefinicion.Rows.Add(oid,marca, modelo);
                    }

                }
                else
                {
                    OcultarMarcaModelo();
                    txtBCantidad.Text = "0";
                    txtBCantidad.Enabled = true;

                    foreach (string cabezal in datosCabezales)
                    {
                        string nombre = cabezal.Split(':')[0];
                        Type tipoDato = Type.GetType("System." + cabezal.Split(':')[1].ToString());
                        dataGridDefinicion.Columns.Add(nombre, nombre);
                        dataGridDefinicion.Columns[idCol].ValueType = tipoDato;
                        idCol++;
                    }
                }
                dataGridDefinicion.Visible = true;
                //dataGridDefinicion.Enabled = false;
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
            if (!cBTipos.SelectedItem.ToString().Contains("Componente"))
            {
                if (numeroFilas <= 0)
                {
                    dataGridDefinicion.Rows.Clear();
                    dataGridDefinicion.Enabled = false;
                }
                else
                {
                    dataGridDefinicion.Rows.Clear();
                    dataGridDefinicion.Rows.Add(numeroFilas);
                    dataGridDefinicion.Enabled = true;
                }
            }
            else
            {
                dataGridDefinicion.Enabled = true;
                dataGridDefinicion.ReadOnly = true;
               
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

        private void txtBMarca_TextChanged(object sender, EventArgs e)
        {
            txtBCantidad.Enabled = false;
        }

        private void txtBModelo_TextChanged(object sender, EventArgs e)
        {
            txtBCantidad.Enabled = false;
        }

    }
}
