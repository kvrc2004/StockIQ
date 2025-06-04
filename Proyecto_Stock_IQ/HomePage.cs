using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Stock_IQ.FormInventario;
using static Proyecto_Stock_IQ.HacerPedido;

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
            CargarProductosBajoStock();
            MostrarProductoMasUsado();
            MostrarTotalProductos();
            TemasApp.AplicarTema(this);
            MostrarTotalOrdenes();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void listView_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_orden.BackColor = Color.FromArgb(246, 241, 236);
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
            FormInventario frm = new FormInventario(true); // true = mostrar panel al cargar
            frm.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes(true); // Activar panel desde constructor
            frm.Show();
            this.Hide(); // Oculta la ventana actual
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

        private void CargarProductosBajoStock()
        {
            listView_orden.Items.Clear();

            // Ordenar por existencia (de menor a mayor)
            var productosOrdenados = FormInventario.listaProductos
                .OrderBy(p => Convert.ToInt32(p.Existencia)) // Asegúrate que Existencia es numérica
                .ToList();

            foreach (var producto in productosOrdenados)
            {
                ListViewItem item = new ListViewItem(producto.Producto);
                item.SubItems.Add(producto.Existencia);
                listView_orden.Items.Add(item);
            }
        }

        private void MostrarProductoMasUsado()
        {
            listView_masUsado.Items.Clear();

            var productosOrdenados = FormInventario.listaProductos
                .OrderByDescending(p => int.Parse(p.Existencia)) // ordenar por existencias numéricas
                .ToList();

            var masUsado = productosOrdenados.FirstOrDefault();
            if (masUsado != null)
            {
                ListViewItem item = new ListViewItem(masUsado.Producto);
                item.SubItems.Add(masUsado.Existencia);
                listView_masUsado.Items.Add(item);
            }
        }

        private void MostrarTotalProductos()
        {
            listView_totalItems.Items.Clear();

            int total = FormInventario.listaProductos.Count;

            ListViewItem item = new ListViewItem(total.ToString());
            listView_totalItems.Items.Add(item);
        }

        public void MostrarTotalOrdenes()
        {
            listView_totalOrdenes.Items.Clear();

            ListViewItem item = new ListViewItem(ContadorOrdenes.TotalOrdenes.ToString());
            listView_totalOrdenes.Items.Add(item);
        }

    }
}
