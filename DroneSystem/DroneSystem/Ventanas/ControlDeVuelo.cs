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
    public partial class ControlDeVuelo : Form, IObserver
    {
        bool finAutomatico = false;

        public ControlDeVuelo()
        {
            InitializeComponent();
            DibujarInicial();
        }

        private void DibujarInicial()
        {
            List<List<string>> conf = Fachada.GetInstancia().InfoDronActivo();
            if (Fachada.GetInstancia().DronVolando())
            {
                foreach (Control con in this.Controls)
                {
                    if (con.Name.Contains("listaB"))
                    {
                        this.Controls.Remove(con);
                    }
                }
                int idL = 1;
                int nivel = 1;
                int aumento = 1;
                foreach (List<string> lista in conf)
                {
                    ListBox lb = new ListBox();
                    lb.SelectionMode = SelectionMode.None;
                    lb.DataSource = lista;
                    lb.Name = "listaB" + idL;
                    lb.Location = new Point(15 * idL, 50 * nivel);
                    lb.Visible = true;
                    if (aumento == 1)
                        lb.BackColor = Color.Beige;
                    if (lista[lista.Count - 1].Contains("ALARMA"))
                        lb.BackColor = Color.Red;
                    this.Controls.Add(lb);
                    idL += 10;
                    aumento++;
                    if ((aumento % 4) == 0)
                    {
                        nivel += 2;
                        idL = 1;
                    }
                }

            }
            else
            {
                if (Fachada.GetInstancia().DronFuncionando())
                {
                    MessageBox.Show(this,"Vuelo Finalizado, Dron llegó a destino");
                    finAutomatico = true;
                }
                else
                {
                    MessageBox.Show(this,"Vuelo Finalizado, Dron DESTRUIDO");
                    finAutomatico = true;
                }
                
            }
         }

        public void Actualizar()
        {
            //identifico las labels y les cambio valor
            DibujarInicial();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Fachada.GetInstancia().RemoverObserverDron(this);
            Fachada.GetInstancia().TerminarVueloDron();
            if (!finAutomatico)
            MessageBox.Show("Vuelo Finalizado por el Usuario");
            this.Close();
        }

    }
}
