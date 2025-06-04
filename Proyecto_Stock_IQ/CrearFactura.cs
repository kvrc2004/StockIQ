using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Stock_IQ
{
    public partial class CrearFactura : Form
    {
        private List<ProductoSeleccionado> productosSeleccionados = new List<ProductoSeleccionado>();

        public class ProductoSeleccionado
        {
            public string Producto { get; set; }
            public string Cantidad { get; set; }
            public string Categoria { get; set; }

            public ProductoSeleccionado(string producto, string cantidad, string categoria)
            {
                Producto = producto;
                Cantidad = cantidad;
                Categoria = categoria;
            }
        }

        public CrearFactura()
        {
            InitializeComponent();
            CargarProveedoresEnComboBox();
            TemasApp.AplicarTema(this);
        }

        private void CrearFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de crear factura

        }

        private void btn_clientes_Click(object sender, EventArgs e)
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

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana de crear factura
        }

        private void lbl_hacerPedido_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            hacerPedido.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            Cliente.CargarClientesPorDefecto();

            cmb_cliente.DataSource = Cliente.listaClientes;
            cmb_cliente.DisplayMember = "Nombre";

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

        private void listView_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_productos.SelectedItems.Count > 0)
            {
                // Toma el nombre del producto de la columna 2 (índice 1)
                string nombreProducto = listView_productos.SelectedItems[0].SubItems[1].Text;

                // Lo muestra en el textbox llamado txt_producto
                txt_producto.Text = nombreProducto;
            }
        }

        private void btn_guardarCantidad_Click(object sender, EventArgs e)
        {
            if (listView_productos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto de la lista.");
                return;
            }

            string nombreProducto = listView_productos.SelectedItems[0].SubItems[1].Text;
            string cantidad = txt_cantidadProducto.Text.Trim();
            string categoria = cmb_categoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor ingresa cantidad y categoría.");
                return;
            }

            productosSeleccionados.Add(new ProductoSeleccionado(nombreProducto, cantidad, categoria));
            MessageBox.Show("Producto agregado a la factura.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txt_cantidadProducto.Clear();
            cmb_categoria.SelectedIndex = -1;
        }

        private void btn_descargarFactura_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FACTURA GENERADA POR STOCKIQ");
            sb.AppendLine($"Fecha: {DateTime.Now}");
            sb.AppendLine("-------------------------------------------------");

            foreach (var item in productosSeleccionados)
            {
                sb.AppendLine($"Producto: {item.Producto}");
                sb.AppendLine($"Cantidad: {item.Cantidad}");
                sb.AppendLine($"Categoría: {item.Categoria}");
                sb.AppendLine("-------------------------------------------------");
            }

            string rutaArchivo = Path.Combine(Application.StartupPath, "factura_stockiq.txt");

            File.WriteAllText(rutaArchivo, sb.ToString());

            MessageBox.Show($"Factura guardada en:\n{rutaArchivo}", "Descarga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
