using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion_BD;

namespace Nube
{
    public partial class Iniciar_sesion : Form
    {
        public Iniciar_sesion()
        {
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Clear();
            txt_Contraseña.Clear();
        }

        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            Form Formulario_Registrarse = new Registrarse();
            Formulario_Registrarse.Visible = true;
            this.Visible = false;
        }

        private void Btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            if((txt_Usuario.Text != "") && (txt_Contraseña.Text != ""))
            {
                RecibirDatos recibir = new RecibirDatos();
                recibir.Comando = "SELECT * FROM nube.usuarios where BINARY usuario = '" + txt_Usuario.Text + "' and BINARY contraseña = '" + txt_Contraseña.Text + "';";

                if (recibir.Verdad())
                {
                    string Texto;
                    string Nombre;
                    string Apellido;
                    
                    recibir.Comando = "SELECT nombre FROM nube.usuarios where BINARY usuario = '" + txt_Usuario.Text + "'";
                    Nombre = recibir.Dato();
                    
                    recibir.Comando = "SELECT apellido FROM nube.usuarios where BINARY usuario = '" + txt_Usuario.Text + "';";
                    Apellido = recibir.Dato();

                    Texto = Nombre + " " + Apellido;
                    Nube Nube = new Nube(Texto);

     
                    
                    
                    Nube.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña ingresados son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos para iniciar sesion");
            }
 
        } 
    }
}
