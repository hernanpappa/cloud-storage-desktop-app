using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Conexion_BD;

namespace Nube
{
    public partial class Nube : Form
    {

        string Usuario = "";
        string Texto = "";
        public Nube()
        {
            InitializeComponent();
        }
        public Nube(string Texto)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido: " + Texto;

        }

        private void Nube_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubirArchivo_Click(object sender, EventArgs e)
        {

            byte[] file = null;

            if (txtDirArchivo.Text.Trim().Equals("") || txtDirArchivo.Text.Trim().Equals("Inserte su archivo aqui"))
            {
                MessageBox.Show("Selecciona un archivo valido");
                return;
            }
            else
            {
                
                Stream myStream = archivo.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }
            }

            EnviarDatos enviar = new EnviarDatos();

            DateTime fecha = new DateTime();
            DateTimePicker fechapicker = new DateTimePicker();
            fecha = fechapicker.Value;

            MessageBox.Show(fecha.ToString());
           //enviar.Comando = "Insert into nube.archivos ('ModLinux1', '.pdf', '1Mb', " + fecha + ", 

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;

        }

        private void BtnEncontrarArchivo_Click(object sender, EventArgs e)
        {
            archivo.InitialDirectory = "C:\\";
            archivo.Filter = "Todos los archivos (*.*)|*.*";
            archivo.FilterIndex = 1;
            archivo.RestoreDirectory = true;

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtDirArchivo.Text = archivo.FileName;
            }

        }
    }
}
