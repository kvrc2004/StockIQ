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
    public partial class Configuracion : Form
    {
        
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de configuración
        }
    }
}
