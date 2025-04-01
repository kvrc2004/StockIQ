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
using static Proyecto_Stock_IQ.Registrar;

namespace Proyecto_Stock_IQ
{
    public partial class IniciarSesion: Form
    {
        private List<Usuario> usuarios = new List<Usuario>(); //Inicializa la lista
        public IniciarSesion(List<Usuario> user) //Sigue dando error al momento de recibir la lista
        {
            InitializeComponent();
            this.usuarios = user;
            usuarios = new List<Usuario>();
        }
        private void gbtn_Ingresar_Click_1(object sender, EventArgs e) //Compara si el elemento existe en la lista y lo deja ingresar
        {
            Usuario usuario = usuarios.FirstOrDefault(u => u.Documento == gtxt_Documento.Text && u.Password == gtxt_Documento.Text);
            if (usuario != null) {
                MessageBox.Show($"Bienvenido {usuario.Nombre} ");
                if (usuario.Rol != "admin"){
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else{
                    MessageBox.Show("TEST ");
                    // TODO: Agregar panel Admin
                }
            }
        }
        private void glbl_Registrar_Click(object sender, EventArgs e) //Cambia a la ventana de Registrar
        {
            Registrar registrar = new Registrar();
            registrar.ShowDialog(); // Se usa ShowDialog para que no se pueda acceder a la ventana anterior sin cerrar la actual, y asi se guarden los datos en la listas
            //registrar.Show();
            //this.Hide();
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
            /* 
                REVISAR COMO FUNCIONARIA EL USO DE LAS LISTAS PARA MANEJAR LOS USUARIOS
                YA QUE NO SE CREAN EN LA MISMA PESTAÑA Y NO PUEDEN SER PUBLICOS
            */