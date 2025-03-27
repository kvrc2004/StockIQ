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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
        
        private void gtxt_Nombre_Enter(object sender, EventArgs e)
        {
            gtxt_Nombre.Text = "Documento de Identidad";
            if (gtxt_Nombre.Text == "Documento de Identidad") {
                gtxt_Nombre.Text = ""; // Borra el texto solo si está vacío
                gtxt_Nombre.ForeColor = Color.Black; // Cambia el color del texto a negro 
            }
        }
        private void gtxt_Nombre_Leave(object sender, EventArgs e)
        {
            if (gtxt_Nombre.Text == "") {
                gtxt_Nombre.Text = "Documento de Identidad";
                gtxt_Nombre.ForeColor = Color.Silver;// Cambia el color del texto a plateado 
            }
        }
        private void gtxt_Documento_Enter(object sender, EventArgs e)
        {
            gtxt_Documento.Text = "Documento de Identidad";
            if (gtxt_Documento.Text == "Documento de Identidad") {
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
            gtxt_Password.Text = "Documento de Identidad";
            if (gtxt_Password.Text == "Documento de Identidad") {
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
        /*
        private void glbl_Registrar_Click(object sender, EventArgs e)
        {
            IniciarSesion ingresar = new IniciarSesion();
            ingresar.Show();
            this.Hide();
        }
        */
        private void glbl_IniciarSesion_Click(object sender, EventArgs e) // ENVIA AL USUARIO A VENTANA DE INICIO DE SESION
        {
            IniciarSesion ingresar = new IniciarSesion();
            ingresar.Show();
            this.Hide();
        }

    }
}
