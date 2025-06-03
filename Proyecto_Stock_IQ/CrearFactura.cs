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
using static Proyecto_Stock_IQ.Clientes;

namespace Proyecto_Stock_IQ
{
    public partial class CrearFactura : Form
    {
        public void CargarClientes(List<Cliente> listaClientes)
        {
            cmb_cliente.DataSource = listaClientes;
            cmb_cliente.DisplayMember = "Nombre";  // o el campo que quieras mostrar
        }

        public void CargarProveedores(List<Proveedores> listaProveedores)
        {
            cmb_proveedor.DataSource = listaProveedores;
            cmb_proveedor.DisplayMember = "Nombre";
        }


        public CrearFactura()
        {
            InitializeComponent();
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

        private void btn_descargarFactura_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\Daniela\source\repos\StockIQ\facturas" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine($"Cliente: {cmb_cliente.Text}");
                sw.WriteLine($"Proveedor: {cmb_proveedor.Text}");
                sw.WriteLine("Productos y cantidades:");

            }

            MessageBox.Show("Factura descargada exitosamente en: " + ruta);
        }
    }
}
