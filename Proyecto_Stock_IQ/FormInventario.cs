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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void lbl_inicio_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void lbl_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            CrearFactura crearFactura = new CrearFactura();
            crearFactura.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void lbl_crearFractura_Click(object sender, EventArgs e)
        {
            CrearFactura crearFactura = new CrearFactura();
            crearFactura.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void lbl_hacerPedido_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void FormInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }
    }
}
