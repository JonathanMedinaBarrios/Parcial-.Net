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
        public static DataSet Ejecutar(string cmd)
        {

            NpgsqlConnection con = new NpgsqlConnection("Server=localhost; User Id=postgres;Password=proyecto;Database =todoapp; Integrated Security =True");
            con.Open();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter DP = new NpgsqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }
    }
}
