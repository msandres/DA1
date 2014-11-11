using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DroneSystem.Dominio.Persistencia
{
    public class CargaDatosBaseSQL:ICargaDatos
    {

        public void Cargar()
        {
            string constr = ConfigurationManager.ConnectionStrings["BASELOCAL"].ToString(); 
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand comand = new SqlCommand("SELECT *  FROM [DRONSYSTEM].[dbo].[ComponenteAbstacto]", con);

            //int cant = comand.ExecuteNonQuery();

            SqlDataReader dr = comand.ExecuteReader();
            
            DataTable dt = new DataTable();

            dt.Load(dr);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
            }

            con.Close();
        }

    }
}
