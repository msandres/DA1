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
    public partial class AgregarPlanVuelo : Form
    {
        public AgregarPlanVuelo()
        {
            InitializeComponent();
            AumentarNroPlan(1);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }


        private void ValidacionesDataGrid()
        {

        }

        private void ValidarCeldaDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCoordenadas.CurrentCell != null && datagridCoordenadas.CurrentCell.Value!=null && datagridCoordenadas.CurrentCell.Value.ToString().Length > 0)
            {
                int idRow = e.RowIndex;
                int idCol = e.ColumnIndex;
                double resultado;
                if (!Double.TryParse(datagridCoordenadas.CurrentCell.Value.ToString(), out resultado))
                {
                    MessageBox.Show("El tipo definido para la celda no es correcto !!! \n Debe ser double");

                    datagridCoordenadas.CurrentCell.Value = "";                    
                }
            }
        }

        private void ValidarNuevoRegistro(object sender, DataGridViewRowsAddedEventArgs e)
        { 
            
            if (e.RowIndex > 0)
            {
                if (e.RowIndex > 1)
                {
                    if (datagridCoordenadas.Rows[e.RowIndex - 2].Cells[1].Value != null &&
                        datagridCoordenadas.Rows[e.RowIndex - 2].Cells[2].Value != null &&
                        datagridCoordenadas.Rows[e.RowIndex - 2].Cells[3].Value != null)
                    {
                        AumentarNroPlan(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Completar Coordenada !!!");
                        //datagridCoordenadas.Rows[e.RowIndex-1].Selected = true;
                        //datagridCoordenadas.Rows.RemoveAt(e.RowIndex);
                        //datagridCoordenadas.Refresh();
                        //datagridCoordenadas.Refresh();
                    }
                }
            }
        }

        private void AumentarNroPlan(int nuevaFila)
        {
            datagridCoordenadas.Rows[nuevaFila-1].Cells[0].Value = nuevaFila;
        }

        private bool ValidacionesVelocidad()
        {
            bool valido = true;

            return valido;
        }

    }
}
