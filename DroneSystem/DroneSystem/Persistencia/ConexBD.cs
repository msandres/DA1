using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.Persistencia
{
    public class ConexBD
    {
        private string conStr = ConfigurationManager.ConnectionStrings["BASELOCAL"].ToString();
        private SqlConnection conexion;

        private static ConexBD instancia;

        public static ConexBD GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexBD();
                instancia.conexion = new SqlConnection(instancia.conStr);
            }
            return instancia;
        }

        public void EjecutarSentencia(String sentencia)
        {
            conexion.Open();
            SqlCommand comand = new SqlCommand(sentencia, conexion);

            try
            {
                int cant = comand.ExecuteNonQuery();
            }
            catch (Exception e) 
            {
               
            }

            conexion.Close();
        }

        public DataTable TraerDatos(String sentencia)
        {
            conexion.Open();
            SqlCommand comand = new SqlCommand(sentencia, conexion);

            SqlDataReader SqlDR = comand.ExecuteReader();

            DataTable Dtable = new DataTable();

            Dtable.Load(SqlDR);
            conexion.Close();

            return Dtable;
        }
    }
}
