using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Npgsql; 

namespace libreriaToDoApp
{
    public class Sql
    {
        static NpgsqlConnection con = new NpgsqlConnection("Server=localhost; User Id=postgres;Password=proyecto;Database =parcial; Integrated Security =True");


        public static DataSet Ejecutar(string cmd) // ejecuta procedimiento almacenado de consultar 
        {

            con.Open();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter DP = new NpgsqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }

        public static void Ejecutar2(String cmd) { // ejecutar procedimiento de guardar y eliminar 
            con.Open();
            NpgsqlCommand sentencia = new NpgsqlCommand(cmd, con);
            sentencia.ExecuteScalar();
            con.Close();
        }
    }
}
