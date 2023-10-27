using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Practica_1
{
    public partial class Login : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;DataBase=practica1;Uid=root;Pwd=;");
        MySqlCommand comando = new MySqlCommand("SELECT * FROM customers");
        MySqlDataReader read;

        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new MySqlCommand("SELECT * FROM users WHERE username='"
               + textBoxUsuario.Text + "' AND password='" + textBoxPassword.Text + "'");

            comando.Connection = conexion;

            read = comando.ExecuteReader();

            if (read.HasRows)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
            conexion.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void IconoCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnAceptar_Click(sender, e);
            }
        }
    }
}
