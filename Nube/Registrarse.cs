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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            bool lleno = true;

            RecibirDatos recibir = new RecibirDatos();
            EnviarDatos enviar = new EnviarDatos();

            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Usuario = txtUsuario.Text;
            string Correo = txtCorreo.Text;
            string Contraseña = txtContraseña.Text;
            string ReContraseña = txtReContraseña.Text;

            if (Nombre == "") lleno = false;
            if (Apellido == "") lleno = false;
            if (Usuario == "") lleno = false;
            if (Correo == "") lleno = false;
            if (Contraseña == "") lleno = false;
            if (ReContraseña == "") lleno = false;



            if (lleno == true)
            {
                if (Contraseña == ReContraseña)
                {
                    recibir.Comando = "SELECT * FROM nube.usuarios WHERE BINARY usuario ='" + Usuario + "';";
                    if (recibir.Verdad() == false)
                    {
                        Form Ingresar = new Iniciar_sesion();

                        enviar.Comando = "INSERT INTO nube.usuarios(`nombre`, `apellido`, `usuario`, `mail`, `contraseña`) VALUES('" + Nombre + "', '" + Apellido + "', '" + Usuario + "', '" + Correo + "', '" + Contraseña + "')";
                        
                        if (enviar.Send())
                        {
                            MessageBox.Show("Usted se ah registrado exitosamente!");
                            Visible = false;
                            Ingresar.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al registrarse");
                        }



                    }
                    else MessageBox.Show("El usuario ya ah sido registrado");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los datos antes de registrarse");
            }
        }
    }
}
