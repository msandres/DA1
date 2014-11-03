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
        public ControlDeVuelo()
        {
            InitializeComponent();
            DibujarInicial();
        }

        private void DibujarInicial()
        {
            List<List<string>> conf = Fachada.GetInstancia().InfoDronActivo();
            if (conf != null)
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
                Fachada.GetInstancia().RemoverObserverDron(this);
                MessageBox.Show("Vuelo Finalizado");
            }
            //listBComDron.Refresh();

            //int idNivel1=0;
            //foreach (List<string> lista in conf)
            //{

            //        Label lb = new Label();
            //        lb.Text = lista[0];
            //        lb.Name = "label" + idNivel1;
            //        lb.Location = new Point(20, 50);
            //        lb.Visible = true;
            //        this.Controls.Add(lb);

            //        Label lb1 = new Label();
            //        lb1.Text = lista[1];
            //        lb1.Name = "label1" + idNivel1;
            //        lb1.Location = new Point(200, 50);
            //        lb1.Visible = true;
            //        this.Controls.Add(lb1);

            //        Label lb2 = new Label();
            //        lb2.Text = lista[2];
            //        lb2.Name = "label2" + idNivel1;
            //        lb2.Location = new Point(lista[1].Length + lista[0].Length + 20, 50);
            //        lb2.Visible = true;
            //        this.Controls.Add(lb2);
             
            //    if (idNivel1 > 0)
            //    {
            //        int idNivel2 = 0;
            //        //foreach ()
            //        //{
            //        //}
            //    }
                
                
            //}

            //Label lb3 = new Label();
            //lb3.Text = "hola";
            //lb3.Name = "label33" + "020";
            //lb3.Location=new Point(40, 60);
            //lb3.Visible = true;
            //this.Controls.Add(lb3);
            

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
            this.Close();
        }

    }
}
