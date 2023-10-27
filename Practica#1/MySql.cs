using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class MySql
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;DataBase=practica1;Uid=root;Pwd=;");
        MySqlCommand comando = new MySqlCommand("SELECT * FROM customers");
        MySqlDataReader reader;

        public MySql(string host, string us, string pwd, string bd, string puerto= "3306") : base()
        {
            
        }
        
    }
}
