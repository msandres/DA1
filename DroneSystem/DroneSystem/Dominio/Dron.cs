using DroneSystem.Dominio;
using DroneSystem.Dominio.Composite;
using DroneSystem.PatronesExtras.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneSystem
{
    public class Dron : Observable
    {
        private Timer timeFunc = new Timer();
        private bool funcionando;
        private bool enMovimiento;
        private static int serieClase;  //mantengo el numero de serie de la clase, así creo un dron nuevo con un codigo nuevo cada vez

        private string Nombre;
        private int serieDron;
        private string color;
        private string controlRemoto;
        private double precio;

        private IList<ComponenteAbstracto> listcomponentes;
        private double X;
        private double Y;
        private double Z;


        private double avanceX;
        private double avanceY;
        private double avanceZ;

        private List<double> recorridoX;
        private List<double> recorridoY;
        private List<double> recorridoZ;

        //creo el dron por defecto en la posicion 0,0,0 y con velocidad de avance 1,1,1 y con la lista vacia
        public Dron(string nombreDron, string colorDron, string modeloControl)
        {
            serieClase++;  //aumento la serie global del dron
            this.Nombre = nombreDron;
            this.serieDron = serieClase;
            this.color = colorDron;
            this.controlRemoto = modeloControl;
            this.funcionando = true;
            this.enMovimiento = false;



            this.listcomponentes = new List<ComponenteAbstracto>();
            this.X = 0;
            this.Y = 0;
            this.Z = 0;

            this.avanceX = 1;
            this.avanceY = 1;
            this.avanceZ = 1;

            Observers = new List<IObserver>();

            timeFunc.Enabled = false;
            timeFunc.Interval = 1000;
            timeFunc.Tick += new EventHandler(Funcionamiento);

        }

        public void AgregarComponentes(List<ComponenteAbstracto> listaComp)
        {
            this.listcomponentes = listaComp;
            foreach (ComponenteAbstracto cmp in this.listcomponentes)
            {
                AgregarOb(cmp);
            }
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public int GetNroSerie()
        {
            return this.serieDron;
        }

        public string GetColor()
        {
            return this.color;
        }

        public string GetControlRemoto()
        {
            return this.controlRemoto;
        }

        public double UbicacionX()
        {
            return this.X;
        }
        public double UbicacionY()
        {
            return this.Y;
        }
        public double UbicacionZ()
        {
            return this.Z;
        }
        public double GetPrecio()
        {
            return this.precio;
        }
        public void SetPrecio(double precio)
        {
            this.precio=precio;
        }
        public void IniciarVuelo(PlanVuelo plan)
        {
            //configuro la velocidad de avance
            this.avanceX = plan.GetVelocidadX();
            this.avanceY = plan.GetVelocidadY();
            this.avanceZ = plan.GetVelocidadZ();

            this.recorridoX = new List<double>();
            this.recorridoY = new List<double>();
            this.recorridoZ = new List<double>();
            int cantPuntos = 0;
            while (cantPuntos < plan.GetRecorridoX().Count)
            {
                this.recorridoX.Add(plan.GetRecorridoX()[cantPuntos]);
                this.recorridoY.Add(plan.GetRecorridoY()[cantPuntos]);
                this.recorridoZ.Add(plan.GetRecorridoZ()[cantPuntos]);
                cantPuntos++;
            }

            this.X = this.recorridoX[0];
            this.Y = this.recorridoY[0];
            this.Z = this.recorridoZ[0];

            this.enMovimiento = true;
            timeFunc.Enabled = true;
        }
        public void DetenerVuelo()
        {
            this.enMovimiento = false;
            timeFunc.Enabled = false;
        }

        private void Funcionamiento(Object myObject, EventArgs myEventArgs)
        {
            if (Funciona() && EnMovimiento())
            {
                MuevoPosicion();
                Notify();
                Console.WriteLine("Pos X: " + X + " Pos Y: " + Y + " Pos Z: " + Z);
            }
            else
            {
                timeFunc.Enabled = false;
            }
        }

        private void MuevoPosicion()
        {
            if (this.recorridoX.Count > 0 || this.recorridoY.Count > 0 || this.recorridoZ.Count > 0)  // si tengo puntos por recorrer
            {
                double sigPosX = this.X;
                double sigPosY = this.Y;
                double sigPosZ = this.Z;
                if (this.recorridoX.Count > 0)
                {
                    sigPosX = this.recorridoX[0];
                    if (this.X==sigPosX)
                        this.recorridoX.RemoveAt(0);
                }
                if (this.recorridoY.Count > 0)
                {
                    sigPosY = this.recorridoY[0];
                    if (this.Y==sigPosY)
                        this.recorridoY.RemoveAt(0);
                }
                if (this.recorridoZ.Count > 0)
                {
                    sigPosZ = this.recorridoZ[0];
                    if (this.Z==sigPosZ)
                        this.recorridoZ.RemoveAt(0);
                }

                if ((sigPosX - this.X) != 0)
                {
                    double avanzar = this.avanceX;
                    if (Math.Abs(sigPosX - this.X) < Math.Abs(avanzar))
                        avanzar = Math.Abs(sigPosX - this.X);

                    avanzar = Math.Sign(sigPosX - this.X) * avanzar;
                    
                    this.X = this.X + avanzar;
                }

                if ((sigPosY - this.Y) != 0)
                {
                    double avanzar = this.avanceY;
                    if (Math.Abs(sigPosY - this.Y) < Math.Abs(avanzar))
                        avanzar = Math.Abs(sigPosY - this.Y);

                    avanzar = Math.Sign(sigPosY - this.Y) * avanzar;

                    this.Y = this.Y + avanzar;
                }

                if ((sigPosZ - this.Z) != 0)
                {
                    double avanzar = this.avanceZ;
                    if (Math.Abs(sigPosZ - this.Z) < Math.Abs(avanzar))
                        avanzar = Math.Abs(sigPosZ - this.Z);

                    avanzar = Math.Sign(sigPosZ - this.Z) * avanzar;

                    this.Z = this.Z + avanzar;
                }
            }
            else
            {
                this.enMovimiento = false;
            }

        }
        public bool Funciona()
        {
            return this.funcionando;
        }

        public bool EnMovimiento()
        {
            return this.enMovimiento;
        }

        public IList<ComponenteAbstracto> GetComponentes()
        {
            return this.listcomponentes;
        }

        public override void AgregarOb(IObserver observer)
        {
            Observers.Add(observer);
        }

        public override void RemoverOb(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}

