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
        private List<Proveedor> listaProvedores = new List<Proveedor>();
		private IEnumerable<object> listaProveedores;

		public class Proveedor
        {
			public string Id { get; set; }
			public string Producto { get; set; }
			public string Existencia { get; set; }
			public string Categoria { get; set; }

			public Proveedor(string id, string producto, string existencia, string categoria)
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
			CargarProveedoresPorDefecto();
			CargarProveedores();

		}
		private void CargarProveedoresPorDefecto()
		{
			listaProvedores.Add(new Proveedor("100", "Pastillas Frenos apache 160", "50", "Frenos"));
			listaProvedores.Add(new Proveedor("200", "1/4 de aceite motul 5100", "25", "Aceite"));
			listaProvedores.Add(new Proveedor("300", "Juego de llaves hexagonales", "10", "Herramientas"));
			listaProvedores.Add(new Proveedor("400", "llanta delantera kenda 90/10", "8", "llantas"));
			
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
		private void CargarProveedores()
		{
			listView_inventario.Items.Clear();

			foreach (var proveedor in listaProvedores)
			{
				ListViewItem item = new ListViewItem(proveedor.Id);
				item.SubItems.Add(proveedor.Producto);
				item.SubItems.Add(proveedor.Existencia);
				item.SubItems.Add(proveedor.Categoria);

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

			if (listaProvedores.Exists(p => p.Producto == nuevoProducto))
			{
				MessageBox.Show("Ese  producto  ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var nuevoProveedor = new Proveedor(nuevoId, nuevoProducto, nuevoExistencia, nuevaCategoria);
			listaProvedores.Add(nuevoProveedor);

			MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			txt_idProducto.Clear();
			txt_agregarProducto.Clear();
			txt_existenciasProducto.Clear();

			panel_agregarProducto.Visible = true;
			panel_agregarProducto.SendToBack();

			CargarProveedores();
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
			if (listView_inventario.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selecciona un Producto de la lista");
				return;
			}
			string productoSeleccionado = listView_inventario.SelectedItems[0].SubItems[1].Text;
			Proveedor proveedor = listaProvedores.Find(p => p.Producto == productoSeleccionado);

			if (proveedor != null)

			{
				// Pre-cargar datos en campos de edición
				txt_editarID.Text = proveedor.Id;
				txt_editarProducto.Text = proveedor.Producto;
				txt_editarExistencias.Text = proveedor.Existencia;
				//cmb_editarCategoria.Text = proveedor.Categoria;
				//cmb_editarCategoria.Text. = proveedor.Categoria;
				cmb_editarCategoria.Items.Clear();
				foreach (ListViewItem item in listView_inventario.Items)
				{
					string valor = item.SubItems[3].Text;
					cmb_editarCategoria.Items.Add(valor);
				}

				


				panel_editarProducto.Visible = true;
				panel_editarProducto.BringToFront();
				int margenInferior = 20;
				int x = (this.Width - panel_editarProducto.Width) / 2;
				int y = (this.Height - panel_editarProducto.Height) / 2 - margenInferior;
				panel_editarProducto.Location = new Point(x, y);
			}
			else
			{
				MessageBox.Show("No se encontró el producto");
			}
		}

		private void btn_actualizarProducto_Click(object sender, EventArgs e)// el ultimo paso para guardar 
		{
			if (listView_inventario.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selecciona un Producto de la lista");
				return;
			}
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

			string proveedorOriginal =listView_inventario.SelectedItems[0].SubItems[0].Text;

			Proveedor proveedor = listaProvedores.Find(p => p.Producto == nuevoProducto);

			if (proveedor != null)
			{
				proveedor.Id = nuevoId;
				proveedor.Producto = nuevoProducto;
				proveedor.Existencia = nuevoExistencia;
				proveedor.Categoria = nuevaCategoria;

				CargarProveedores();
				MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				panel_agregarProducto.Visible = false;

			}
			else
			{
				MessageBox.Show("No se encontro el producto");
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
			var productoAEliminar = listaProvedores.Find(p => p.Producto == productoSeleccionado);

			if (productoAEliminar != null)

			{
				var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar el producto {productoAEliminar.Id}?",
													"Confirmar eliminación",
													MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirmResult == DialogResult.Yes)
				{
					listaProvedores.Remove(productoAEliminar);


					CargarProveedores();

					MessageBox.Show("Cliente eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("No se encontró el cliente");
			}


		}
	}
}
