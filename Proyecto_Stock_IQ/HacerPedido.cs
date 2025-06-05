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
            CargarProveedoresEnComboBox();
            TemasApp.AplicarTema(this);
        }

        public static class ContadorOrdenes
        {
            public static int TotalOrdenes = 0;
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
            listView_productos.Items.Clear();

            foreach (var item in FormInventario.listaProductos)
            {
                ListViewItem fila = new ListViewItem(item.Id);
                fila.SubItems.Add(item.Producto);
                fila.SubItems.Add(item.Existencia);
                fila.SubItems.Add(item.Categoria);
                listView_productos.Items.Add(fila);
            }
        }

        private void CargarProveedoresEnComboBox()
        {
            cmb_proveedor.Items.Clear();
            foreach (var proveedor in Proyecto_Stock_IQ.Proveedores.listaProveedores)
            {
                cmb_proveedor.Items.Add(proveedor);
            }
        }

        private void btn_guardarCantidad_Click(object sender, EventArgs e)
        {
            if (listView_productos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un producto de la lista.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cantidad.Text) || !int.TryParse(txt_cantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingresa una cantidad válida.");
                return;
            }

            if (cmb_proveedor.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un proveedor.");
                return;
            }

            // Obtener el ID del producto seleccionado
            string idSeleccionado = listView_productos.SelectedItems[0].SubItems[0].Text;

            // Buscar el producto en la lista global
            var producto = FormInventario.listaProductos.Find(p => p.Id == idSeleccionado);

            if (producto != null)
            {
                // Sumar la cantidad nueva a las existencias actuales
                int existenciasActuales = int.Parse(producto.Existencia);
                int nuevaCantidad = existenciasActuales + cantidad;
                producto.Existencia = nuevaCantidad.ToString();

                MessageBox.Show($"Pedido registrado. Ahora hay {nuevaCantidad} unidades de '{producto.Producto}'.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se encontró el producto en el inventario.");
            }

            txt_cantidad.Clear();
            cmb_proveedor.SelectedIndex = -1;

            ContadorOrdenes.TotalOrdenes++;
        }
    }
}
