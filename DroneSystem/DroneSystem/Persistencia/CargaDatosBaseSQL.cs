using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DroneSystem.Persistencia;
using DroneSystem.Dominio.Stock;
using DroneSystem.Dominio.Fabricas;
using DroneSystem.Persistencia.Broker;
using DroneSystem.Dominio.Composite;
using DroneSystem.IPersistenciaPack;

namespace DroneSystem.Dominio.Persistencia
{
    public class CargaDatosBaseSQL : ICargaDatos
    {
        protected ConexBD conexion;
        private IStock stock;
        private FabricaAbstracta fabrica;

        public void Cargar()
        {
            fabrica = new FabricaConcreta();
            stock = Stock.Stock.GetInstancia();
            conexion = ConexBD.GetInstancia();


            //Cargar Planes de Vuelo
            DataTable datos = BrokerAbstracto.CrearBroker(new PlanVuelo()).Cargar();
            int oidAnt = -1;
            if (datos.Rows.Count > 0)
            {
                int idrow = 0;
                while (idrow < datos.Rows.Count)
                {
                    DataRow dtr = datos.Rows[idrow];
                    int idPlan = int.Parse(dtr[0].ToString());
                    oidAnt = idPlan;
                    string nombrePlan = dtr[1].ToString();
                    List<double> recX = new List<double>();
                    List<double> recY = new List<double>();
                    List<double> recZ = new List<double>();

                    double velX = Double.Parse(dtr[2].ToString());
                    double velY = Double.Parse(dtr[3].ToString());
                    double velZ = Double.Parse(dtr[4].ToString());
                    while (idrow < datos.Rows.Count && idPlan == oidAnt)
                    {
                        recX.Add(Double.Parse(dtr[5].ToString()));
                        recY.Add(Double.Parse(dtr[6].ToString()));
                        recZ.Add(Double.Parse(dtr[7].ToString()));
                        idrow++;
                        if (idrow < datos.Rows.Count)
                        {
                            dtr = datos.Rows[idrow];
                            idPlan = int.Parse(dtr[0].ToString());
                        }
                    }
                    PlanVuelo nuevoPlan = fabrica.CrearPlanDeVuelo(nombrePlan, recX, recY, recZ, velX, velY, velZ);
                    nuevoPlan.SetOID(oidAnt);
                    stock.AgregarPlanVuelo(nuevoPlan);
                }
            }

            //Cargar Sensores ----------------
            string consultaSensores = " SELECT C.Tipo,C.OID,C.Marca,C.Modelo,C.DronMedido,M.Unidad,M.Maximo,M.Minimo,M.Precision " +
                                      " FROM [DRONSYSTEM].[dbo].[ComponenteAbstacto] C, [DRONSYSTEM].[dbo].[Medicion] M " +
                                      " Where C.OID=M.OIDComponente order by C.Tipo,C.OID,M.idMedicion";

            datos = conexion.TraerDatos(consultaSensores);
            oidAnt = -1;
            if (datos.Rows.Count > 0)
            {
                int idrow = 0;
                while (idrow < datos.Rows.Count)
                {
                    DataRow dtr = datos.Rows[idrow];
                    int idSensor = int.Parse(dtr[1].ToString());
                    oidAnt = idSensor;

                    //string marca,string modelo,IList<string> unidades,IList<double> max,IList<double> min, IList<double> precision)
                    string tipoSensor = dtr[0].ToString();
                    string marca = dtr[2].ToString();
                    string modelo = dtr[3].ToString();
                    //strng dronmedido = acá no aplica
                    
                    string unidades;
                    double max;
                    double min ;
                    double precision;

                    List<object> configuracion = new List<object>();

                    configuracion.Add(tipoSensor);
                    configuracion.Add(marca);
                    configuracion.Add(modelo);

                    while (idrow < datos.Rows.Count && idSensor == oidAnt)
                    {
                        unidades =dtr[5].ToString();
                        max = Double.Parse(dtr[6].ToString());
                        min = Double.Parse(dtr[7].ToString());
                        precision = Double.Parse(dtr[8].ToString());

                        configuracion.Add(unidades);
                        configuracion.Add(max);
                        configuracion.Add(min);
                        configuracion.Add(precision);

                        idrow++;
                        if (idrow < datos.Rows.Count)
                        {
                            dtr = datos.Rows[idrow];
                            idSensor = int.Parse(dtr[1].ToString());
                        }
                    }
                    ComponenteAbstracto sensor = fabrica.CrearComponente(configuracion);
                    sensor.SetOID(oidAnt);
                    stock.AgregarComponente(sensor);
                }
            }


            //Cargar Drones
            string consultaDron = "SELECT OIDDron,NroSerie,Nombre,Color,Control,Precio,Funcionamiento FROM [DRONSYSTEM].[dbo].[Dron] order by OIDDron ";

            datos = conexion.TraerDatos(consultaDron);
            oidAnt = -1;
            if (datos.Rows.Count > 0)
            {
                int idrow = 0;
                while (idrow < datos.Rows.Count)
                {
                    DataRow dtr = datos.Rows[idrow];
                    int idDron = int.Parse(dtr[0].ToString());
                    oidAnt = idDron;
                    int nroSerie = int.Parse(dtr[1].ToString());
                    string nombre = dtr[2].ToString();
                    string color = dtr[3].ToString();
                    string control = dtr[4].ToString();
                    double precio = Double.Parse(dtr[5].ToString());
                    bool funcionamiento = (dtr[6].ToString().Equals("1"));
                        
                   Dron nuevodron = fabrica.CrearDron(nombre,color, control, precio);
                    nuevodron.SetOID(oidAnt);
                    nuevodron.SetNroSerie(nroSerie);

                    DataTable componentes = conexion.TraerDatos("SELECT OID FROM [DRONSYSTEM].[dbo].[ComponenteAbstacto] where DronMedido="+oidAnt);

                    List<ComponenteAbstracto> componentesDron = new List<ComponenteAbstracto>();

                    foreach (DataRow rowComp in componentes.Rows)
                    {
                        int oidCom = int.Parse(rowComp[0].ToString());
                        int idComp = 0;
                        int cantComponentes = stock.GetComponentes().Count;
                        while (idComp < cantComponentes)
                        {
                            ComponenteAbstracto compAbs = stock.GetComponentes()[idComp];
                            if (compAbs.GetOID() == oidCom)
                            {
                                componentesDron.Add(compAbs);
                                compAbs.AsignarDron(nuevodron);
                                stock.EliminarComponente(compAbs);
                                cantComponentes--;
                            }

                            idComp++;
                        }
                    }

                    nuevodron.AgregarComponentes(componentesDron);
                    stock.AgregarDron(nuevodron);

                    idrow++;
                }
            }

            OPersistente.AumentarOID();
           

        }
    }
}
