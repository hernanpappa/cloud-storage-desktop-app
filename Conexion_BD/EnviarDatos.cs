using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Conexion_BD
{
    public class EnviarDatos : Conexion
    {
        public EnviarDatos()
        {
            comando = "";
        }

        private string comando;

        public string Comando { get => comando; set => comando = value; }

        private Conexion connection = new Conexion();

        public bool Send()
        {
            MySqlCommand Comando = new MySqlCommand(comando, connection.Conectar());
            MySqlDataReader CReader = Comando.ExecuteReader();

            CReader.Read();
            connection.Desconectar();
            return true;
            
        }
    }
}
