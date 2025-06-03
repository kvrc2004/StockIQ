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
    public partial class HomePage : Form
    {
        string rolUsuario;
       
        public HomePage(string rolUsuario) //constructor para el login
        {
            InitializeComponent();
            this.rolUsuario = rolUsuario;
        }
        public HomePage() //constructor por defecto
        {
            InitializeComponent();
            
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void listView_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_stock.BackColor = Color.FromArgb(246, 241, 236);
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btn_agregarItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            panel_agregarcliente.Visible = true;
            panel_agregarcliente.BringToFront();
            int margenInferior = 20;
            int x = (this.Width - panel_agregarcliente.Width) / 2;
            int y = (this.Height - panel_agregarcliente.Height) / 2 - margenInferior;
            panel_agregarcliente.Location = new Point(x, y);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(rolUsuario); // Pasa el rol del usuario a la ventana de inicio
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            CrearFactura crearFactura = new CrearFactura();
            crearFactura.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(rolUsuario); // Pasa el rol del usuario a la ventana de inicio
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana actual    
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void lbl_crearFractura_Click(object sender, EventArgs e)
        {
            CrearFactura crearFactura = new CrearFactura();
            crearFactura.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void lbl_hacerPedido_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana actual
        }
    }
}
