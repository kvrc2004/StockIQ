using Guna.UI2.WinForms;
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
using static Proyecto_Stock_IQ.Registrar;

namespace Proyecto_Stock_IQ
{
    
    public partial class IniciarSesion: Form
    {
        public static class Globales
        {
            // CAMBIEN LA RUTA DEL ARCHIVO A LA QUE CORRESPONDA EN EL PROYECTO
            public static string ArchivoUsuarios = "C:\\Users\\Daniela\\source\\repos\\StockIQ\\Datos\\Usuarios.txt";
        }
        
        public IniciarSesion() 
        {
            InitializeComponent();
        }
        private void gbtn_Ingresar_Click_1(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(gtxt_Documento.Text) || string.IsNullOrWhiteSpace(gtxt_Password.Text))
            {
                MessageBox.Show("Por favor, completa ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(Globales.ArchivoUsuarios))
            {
                MessageBox.Show("El archivo de usuarios no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool loginExitoso = false;
            string rolUsuario = "";

            string[] lineas = File.ReadAllLines(Globales.ArchivoUsuarios);
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length >= 3)
                {
                    string documentoArchivo = partes[1];
                    string contraseñaArchivo = partes[2];
                    string rolArchivo = partes[3];

                    if (documentoArchivo == gtxt_Documento.Text && contraseñaArchivo == gtxt_Password.Text)
                    {
                        loginExitoso = true;
                        rolUsuario = rolArchivo;
                        break;
                    }
                }
            }

            if (loginExitoso)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePage homePage = new HomePage(rolUsuario); // Pasa el rol del usuario a la ventana de inicio
                homePage.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void glbl_Registrar_Click(object sender, EventArgs e) //Cambia a la ventana de Registrar
        {
            Registrar registrar = new Registrar();
            registrar.Show();// Se usa ShowDialog para que no se pueda acceder a la ventana anterior sin cerrar la actual, y asi se guarden los datos en la listas
            this.Hide();
        }
        private void iniciarSesion_Cierre_Ventana(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}