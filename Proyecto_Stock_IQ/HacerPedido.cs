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
    public partial class HacerPedido : Form
    {
        public HacerPedido()
        {
            InitializeComponent();
            TemasApp.AplicarTema(this);
        }

        private void HacerPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
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

        private void HacerPedido_Load(object sender, EventArgs e)
        {

            listView_crearPedido.Items.Clear();

            foreach (var item in FormInventario.listaProvedores)
            {
                ListViewItem fila = new ListViewItem(item.Id);
                fila.SubItems.Add(item.Producto);
                fila.SubItems.Add(item.Existencia);
                fila.SubItems.Add(item.Categoria);
                listView_crearPedido.Items.Add(fila);
            }


        }
    }
}
