using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Stock_IQ.IniciarSesion;

namespace Proyecto_Stock_IQ
{
    public partial class Registrar : Form
    {
        private List<Usuario> usuarios = new List<Usuario>(); //Lista que almacena a los objetos usuarios
        public class Usuario //Constructor
        {
            public string Nombre { get; set; }
            public string Documento { get; set; }
            public string Password { get; set; }
            public string Rol { get; set; }
            public Usuario(string nombre, string documento, string password, string rol)
            {
                Nombre = nombre;
                Documento = documento;
                Password = password;
                Rol = rol;
            }
        }
        public Registrar()
        {
            InitializeComponent();
            usuarios.Add(new Usuario("admin", "1010", "1010", "admin"));
        }

        private void glbl_IniciarSesion_Click(object sender, EventArgs e) // ENVIA AL USUARIO A VENTANA DE INICIO DE SESION
        {
            IniciarSesion ingresar = new IniciarSesion(usuarios);
            ingresar.Show();
            this.Hide();
        }

        private void gbtn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!usuarios.Any(u => u.Documento == gtxt_Documento.Text)){ //El Any recorre la lista pero solo devuelve verdadero o falso
                usuarios.Add(new Usuario(gtxt_Nombre.Text, gtxt_Documento.Text, gtxt_Password.Text, "Usuario comun"));
                MessageBox.Show("Usuario fue creado exitosamente");
            }
            else{
                MessageBox.Show("El usuario ingresado ya existe");
            }
        }
        private void registrar_Cierre_Ventana(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }
    }
}
