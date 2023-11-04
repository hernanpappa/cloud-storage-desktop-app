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
    public class RecibirDatos : Conexion
    {
        public RecibirDatos()
        {
            comando = "";
        }

        private string comando;
        public string Comando { get => comando; set => comando = value; }

        private Conexion connection = new Conexion();

        public bool Verdad()
        {
            MySqlCommand Comando = new MySqlCommand(comando, connection.Conectar());
            MySqlDataReader CReader = Comando.ExecuteReader();
            

            if (CReader.Read())
            {
                connection.Desconectar();
                return true;
            }
            else
            {
                connection.Desconectar();
                return false;
            }
        }

        public string Dato()
        {
            string Data = "";

            MySqlCommand Comando = new MySqlCommand(comando, connection.Conectar());
            MySqlDataReader CReader = Comando.ExecuteReader();

            if (CReader.Read() == true)
            {
                Data = CReader.GetString(0);
                connection.Desconectar();
                return Data;
            }

            connection.Desconectar();
            return Data;
        }
    }
}
