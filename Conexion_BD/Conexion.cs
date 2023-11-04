using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Conexion_BD
{
    public class Conexion
    { 
        static string DatosConexion = "server = localhost; port = 3306 ;username = root; password = 1234; database = nube";
        private MySqlConnection Connection = new MySqlConnection(DatosConexion);

        public MySqlConnection Conectar()
        {
            if(Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }

        public MySqlConnection Desconectar()
        {
            if(Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
            return Connection;
        }
      

    }
}
