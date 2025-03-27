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

namespace Proyecto_Stock_IQ
{
    public partial class IniciarSesion: Form
    {
        private List<String> usuario = new List<String>();
        private List<String> contrasena = new List<String>();
        public IniciarSesion()
        {
            InitializeComponent();
        }
        private void IniciarSesion1_Load(object sender, EventArgs e)
        {

        }

        private void gtxt_Documento_Enter(object sender, EventArgs e)
        {
            gtxt_Documento.Text = "Documento de Identidad";
            if (gtxt_Documento.Text == "Documento de Identidad")
            {
                gtxt_Documento.Text = ""; // Borra el texto solo si está vacío
                gtxt_Documento.ForeColor = Color.Black; // Cambia el color del texto a negro 
            }
        }
        private void gtxt_Documento_Leave(object sender, EventArgs e)
        {
            if (gtxt_Documento.Text == "") {
                gtxt_Documento.Text = "Documento de Identidad";
                gtxt_Documento.ForeColor = Color.Silver;// Cambia el color del texto a plateado 
            }
        }

        private void gtxt_Password_Enter(object sender, EventArgs e)
        {
            gtxt_Password.Text = "Contraseña";
            if (gtxt_Password.Text == "Contraseña") {
                gtxt_Password.Text = ""; // Borra el texto solo si está vacío
                gtxt_Password.ForeColor = Color.Black; // Cambia el color del texto a negro 
            }
        }
        private void gtxt_Password_Leave(object sender, EventArgs e)
        {
            if (gtxt_Password.Text == "") {
                gtxt_Password.Text = "Documento de Identidad";
                gtxt_Password.ForeColor = Color.Silver;// Cambia el color del texto a plateado 
            }
        }

        private void gbtn_Ingresar_Click_1(object sender, EventArgs e)
        {
            /* 
                REVISAR COMO FUNCIONARIA EL USO DE LAS LISTAS PARA MANEJAR LOS USUARIOS
                YA QUE NO SE CREAN EN LA MISMA PESTAÑA Y NO PUEDEN SER PUBLICOS
            */
            for (int i = 0; i < usuario.Count; i++) { 
                if(gtxt_Documento.Text == usuario[i] && gtxt_Password.Text == contrasena[i]) {
                    MessageBox.Show("Bienvenido a la ......"); // TODO: Terminar texto de bienvenida
                    paginaPrincipal paginaPrincipal = new paginaPrincipal(); // TODO: Crear form de pagina principal.
                    paginaPrincipal.Show(); // Muestra la nueva pestaña
                    this.Hide(); // Esconde la pestaña de iniciar sesion
                }
                else {
                    MessageBox.Show("Los datos ingresados son incorrectos");
                }
            }
        }
        private void glbl_Registrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }
    }
}
