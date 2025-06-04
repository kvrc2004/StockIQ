using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Stock_IQ.Clientes;
using static Proyecto_Stock_IQ.IniciarSesion;
using static Proyecto_Stock_IQ.Registrar;


namespace Proyecto_Stock_IQ
{
    public partial class FormInventario : Form
    {
        public static List<ProductoInventario> listaProductos = new List<ProductoInventario>();

        public class ProductoInventario
        {
            public string Id { get; set; }
            public string Producto { get; set; }
            public string Existencia { get; set; }
            public string Categoria { get; set; }

            public ProductoInventario(string id, string producto, string existencia, string categoria)
            {
                Id = id;
                Producto = producto;
                Existencia = existencia;
                Categoria = categoria;
            }
        }

        public FormInventario()
        {
            InitializeComponent();
            TemasApp.AplicarTema(this);
            CargarProductosPorDefecto();
            CargarProductos();
        }

        private void CargarProductosPorDefecto()
        {
            if (listaProductos.Count == 0)
            {
                listaProductos.Add(new ProductoInventario("100", "Pastillas Frenos apache 160", "50", "Frenos"));
                listaProductos.Add(new ProductoInventario("200", "1/4 de aceite motul 5100", "25", "Aceite"));
                listaProductos.Add(new ProductoInventario("300", "Juego de llaves hexagonales", "10", "Herramientas"));
                listaProductos.Add(new ProductoInventario("400", "llanta delantera kenda 90/10", "8", "Llantas"));
            }
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

		private void btn_agregarProducto_Click(object sender, EventArgs e)
		{
				panel_agregarProducto.Visible = true;
				panel_agregarProducto.BringToFront();
				int margenInferior = 20;
				int x = (this.Width - panel_agregarProducto.Width) / 2;
				int y = (this.Height - panel_agregarProducto.Height) / 2 - margenInferior;
				panel_agregarProducto.Location = new Point(x, y);
		}
		private void CargarProductos()
		{
			listView_inventario.Items.Clear();

			foreach (var producto in listaProductos)
			{
				ListViewItem item = new ListViewItem(producto.Id);
				item.SubItems.Add(producto.Producto);
				item.SubItems.Add(producto.Existencia);
				item.SubItems.Add(producto.Categoria);

				listView_inventario.Items.Add(item);
			}
		}

		private void btn_guardarProducto_Click(object sender, EventArgs e)
		{
			string nuevoId = txt_idProducto.Text.Trim();
			string nuevoProducto = txt_agregarProducto.Text.Trim();
			string nuevoExistencia = txt_existenciasProducto.Text.Trim();
			string nuevaCategoria = cmb_categoria.Text.Trim();

			if (string.IsNullOrWhiteSpace(nuevoId) || string.IsNullOrWhiteSpace(nuevoProducto) ||
				string.IsNullOrWhiteSpace(nuevoExistencia) || string.IsNullOrWhiteSpace(nuevaCategoria))
			{
				MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (listaProductos.Exists(p => p.Producto == nuevoProducto))
			{
				MessageBox.Show("Ese  producto  ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var nuevoItem = new ProductoInventario(nuevoId, nuevoProducto, nuevoExistencia, nuevaCategoria);
			listaProductos.Add(nuevoItem);

			MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			txt_idProducto.Clear();
			txt_agregarProducto.Clear();
			txt_existenciasProducto.Clear();

			panel_agregarProducto.Visible = true;
			panel_agregarProducto.SendToBack();

			CargarProductos();
        }

		private void btn_cerraragregar_Click(object sender, EventArgs e)
		{
			panel_agregarProducto.Visible = true;
			panel_agregarProducto.SendToBack();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			panel_editarProducto.Visible = true;
			panel_editarProducto.SendToBack();
		}

		private void PrecargarListViewAcomboBox()
		{
			cmb_editarCategoria.Items.Clear();
			foreach (ListViewItem item in listView_inventario.Items)
			{
				string valor = item.SubItems[3].Text;
				cmb_editarCategoria.Items.Add(valor);
			}
		}

		private void btn_editarProducto_Click(object sender, EventArgs e)
		{
            if (!panel_editarProducto.Visible)
            {
                if (listView_inventario.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecciona un producto de la lista.");
                    return;
                }

                // Obtener producto seleccionado
                string productoSeleccionado = listView_inventario.SelectedItems[0].SubItems[1].Text;
                ProductoInventario producto = listaProductos.Find(p => p.Producto == productoSeleccionado);

                if (producto != null)
                {
                    // Precargar datos
                    txt_editarID.Text = producto.Id;
                    txt_editarProducto.Text = producto.Producto;
                    txt_editarExistencias.Text = producto.Existencia;

                    // Asegurar que la categoría esté en la lista
                    if (!cmb_editarCategoria.Items.Contains(producto.Categoria))
                        cmb_editarCategoria.Items.Add(producto.Categoria);

                    cmb_editarCategoria.Text = producto.Categoria;

                    // Mostrar panel centrado
                    panel_editarProducto.Visible = true;
                    panel_editarProducto.BringToFront();
                    int margenInferior = 20;
                    int x = (this.Width - panel_editarProducto.Width) / 2;
                    int y = (this.Height - panel_editarProducto.Height) / 2 - margenInferior;
                    panel_editarProducto.Location = new Point(x, y);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            }
            else
            {
                // Si el panel está visible y ya se llenaron los campos, vamos a guardar los cambios

                string nuevoId = txt_editarID.Text.Trim();
                string nuevoProducto = txt_editarProducto.Text.Trim();
                string nuevoExistencia = txt_editarExistencias.Text.Trim();
                string nuevaCategoria = cmb_editarCategoria.Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevoId) || string.IsNullOrWhiteSpace(nuevoProducto) ||
                    string.IsNullOrWhiteSpace(nuevoExistencia) || string.IsNullOrWhiteSpace(nuevaCategoria))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idOriginal = listView_inventario.SelectedItems[0].SubItems[0].Text;
                ProductoInventario producto = listaProductos.Find(p => p.Id == idOriginal);

                if (producto != null)
                {
                    producto.Id = nuevoId;
                    producto.Producto = nuevoProducto;
                    producto.Existencia = nuevoExistencia;
                    producto.Categoria = nuevaCategoria;

                    CargarProductos();
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel_editarProducto.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el producto original.");
                }
            }
        }

		private void btn_actualizarProducto_Click(object sender, EventArgs e)// el ultimo paso para guardar 
		{
            if (listView_inventario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto de la lista.");
                return;
            }

            string nuevoId = txt_editarID.Text.Trim();
            string nuevoProducto = txt_editarProducto.Text.Trim();
            string nuevoExistencia = txt_editarExistencias.Text.Trim();
            string nuevaCategoria = cmb_editarCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoId) || string.IsNullOrWhiteSpace(nuevoProducto) ||
                string.IsNullOrWhiteSpace(nuevoExistencia) || string.IsNullOrWhiteSpace(nuevaCategoria))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idOriginal = listView_inventario.SelectedItems[0].SubItems[0].Text;
            ProductoInventario producto = listaProductos.Find(p => p.Id == idOriginal);

            if (producto != null)
            {
                producto.Id = nuevoId;
                producto.Producto = nuevoProducto;
                producto.Existencia = nuevoExistencia;
                producto.Categoria = nuevaCategoria;

                CargarProductos();
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel_editarProducto.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el producto original.");
            }

            if (listaProductos.Exists(p => p.Id == nuevoId))
            {
                MessageBox.Show("Este ID de producto ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

		private void btn_eliminarProducto_Click(object sender, EventArgs e)
		{
			if (listView_inventario.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selecciona un producto de la lista");
				return;
			}

			string productoSeleccionado = listView_inventario.SelectedItems[0].SubItems[1].Text;
			var productoAEliminar = listaProductos.Find(p => p.Producto == productoSeleccionado);

			if (productoAEliminar != null)

			{
				var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar el producto {productoAEliminar.Id}?",
													"Confirmar eliminación",
													MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirmResult == DialogResult.Yes)
				{
					listaProductos.Remove(productoAEliminar);


					CargarProductos();

					MessageBox.Show("Producto eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("No se encontró el producto");
			}


		}
	}
}
