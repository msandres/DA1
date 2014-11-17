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
    public partial class DefinicionDisDron : Form
    {
        public DefinicionDisDron()
        {
            InitializeComponent();
            ArmoGrilla(Fachada.GetInstancia().ObtenerParametros("Componente Compuesto"));
        }
             
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int seleccionados = dataGridDefinicion.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (seleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fila completa !!!");
            }
            else
            {
                string nombre = txtBNombre.Text;
                string color = txtBColor.Text;
                string control = txtBControl.Text;
                double precio = Double.Parse(txtBPrecio.Text);
                List<int> seleccion = new List<int>();
                int idDGS = 0;
                int cantSeleccionados = 0;
                while (idDGS < dataGridDefinicion.Rows.Count)
                {

                    if (dataGridDefinicion.Rows.GetRowState(idDGS).ToString().Contains("Selected"))
                    {
                        seleccion.Add(idDGS - cantSeleccionados);
                        cantSeleccionados++;
                    }
                    idDGS++;
                }

                Fachada.GetInstancia().CrearDron(nombre,color,control,precio,seleccion);
                this.Close();
            }
               
               
        }


        private void ArmoGrilla(IList<string> datosCabezales)
        {
            dataGridDefinicion.Columns.Clear();
            if (datosCabezales.Count>0)
            {  
                    dataGridDefinicion.Columns.Add("Marca", "Marca");
                    dataGridDefinicion.Columns.Add("Modelo", "Modelo");
                  dataGridDefinicion.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                  dataGridDefinicion.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    foreach (string cabezal in datosCabezales)
                    {
                        string marca = cabezal.Split(':')[0];
                        string modelo = cabezal.Split(':')[1];
                        dataGridDefinicion.Rows.Add(marca, modelo);
                    }

                dataGridDefinicion.Visible = true;
            }
            else
            {
                MessageBox.Show("No existen Componentes !!!");
            }
        }

    }
}
