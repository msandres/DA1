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
    public partial class AgregarPlanVuelo : Form
    {
        public AgregarPlanVuelo()
        {
            InitializeComponent();
            AumentarNroPlan(1);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionesDataGrid() && ValidarVelocidades() && ValidarNombre())
            {
                List<double> recX = new List<double>();
                List<double> recY = new List<double>();
                List<double> recZ = new List<double>();

                double velX = double.Parse(txtbVelX.Text);
                double velY = double.Parse(txtbVelY.Text);
                double velZ = double.Parse(txtbVelZ.Text);

                ListarDataGrid(recX, recY, recZ);

                //que la fachada se encargue de crear el plan
                Fachada.GetInstancia().CrearPlanDeVuelo(txtBNombrePlan.Text, recX, recY, recZ, velX, velY, velZ);

                this.Close();
            }
        }

        private void ListarDataGrid(List<double> coordX,List<double> coordY,List<double> coordZ)
        {
            int idrow = 0;
            while (idrow< datagridCoordenadas.Rows.Count-1)
            {
                double X = double.Parse(datagridCoordenadas.Rows[idrow].Cells[1].Value.ToString());
                double Y = double.Parse(datagridCoordenadas.Rows[idrow].Cells[2].Value.ToString());
                double Z = double.Parse(datagridCoordenadas.Rows[idrow].Cells[3].Value.ToString());
                coordX.Add(X);
                coordY.Add(Y);
                coordZ.Add(Z);
                idrow++;
            }
        }

        private bool ValidacionesDataGrid()
        {
            bool dataGridOK = true;
            int idRow = 0;
            while (idRow < datagridCoordenadas.Rows.Count-1  && dataGridOK)
            {
                DataGridViewRow fila = datagridCoordenadas.Rows[idRow];
                if (fila.Cells[1].Value == null || fila.Cells[2].Value == null || fila.Cells[3].Value == null)
                {
                    dataGridOK = false;
                }
                idRow++;
            }

            if (!dataGridOK)
            {
                Mensajes("No se puede Agregar Plan, definir bien las coordenadas de todos los puntos !!!");
            }
            else 
            {
                if (idRow < 2)
                {
                    dataGridOK = false;
                    Mensajes("El Plan debe tener al menos dos puntos !!!");
                }
            }
            return dataGridOK;
        }

        private void ValidarCeldaDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCoordenadas.CurrentCell != null && datagridCoordenadas.CurrentCell.Value!=null && datagridCoordenadas.CurrentCell.Value.ToString().Length > 0)
            {
                
                if (!ValidarDouble(datagridCoordenadas.CurrentCell.Value.ToString()))
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
                        Mensajes("Cuidado, quedó una coordenada sin completar !!!");
                        AumentarNroPlan(e.RowIndex);
                    }
                }
            }
        }

        private void AumentarNroPlan(int nuevaFila)
        {
            datagridCoordenadas.Rows[nuevaFila - 1].Cells[0].Value = nuevaFila;
            datagridCoordenadas.Rows[nuevaFila - 1].Cells[0].Style.BackColor = Color.Gray;

            if (nuevaFila == 1)
                datagridCoordenadas.CurrentCell= datagridCoordenadas.Rows[nuevaFila - 1].Cells[1];
            
            
            
        }

        private bool ValidacionesVelocidad()
        {
            bool valido = true;

            return valido;
        }

        private bool ValidarDouble(string cadena)
        { 
            double resultado;
            return Double.TryParse(cadena, out resultado) && cadena.Length>0;

        }

        private void Mensajes(string mje)
        {
            MessageBox.Show(mje);
        }

        private void ValidarVelocidad(object sender, EventArgs e)
        {
            string vel = null;
            vel = (sender as TextBox).Text;
            
            if (!ValidarDouble(vel) && vel.Length>0)
            {
                Mensajes("El tipo de la Velocidad no es el correcto !!!");
                (sender as TextBox).Text = "";
            }
        }

        private bool ValidarVelocidades()
        {
            bool valido = true;
            valido = txtbVelX.Text.Length > 0 && txtbVelY.Text.Length > 0 && txtbVelZ.Text.Length > 0;
            if (!valido)
                Mensajes("Definir Velocidad en todas las coordenadas !!!");

            return valido;
        }

        private bool ValidarNombre()
        {
            bool valido = true;
            valido = txtBNombrePlan.Text.Length > 0;
            if (!valido)
                Mensajes("Definir Nombre al Plan de Vuelo !!!");

            return valido;
        }
    }
}
