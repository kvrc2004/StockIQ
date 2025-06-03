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
    public partial class Proveedores : Form
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public class Proveedor
        {
            public string NombreContacto { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Empresa { get; set; }

            public Proveedor(string nombreContacto, string correo, string telefono, string empresa)
            {
                NombreContacto = nombreContacto;
                Correo = correo;
                Telefono = telefono;
                Empresa = empresa;
            }
        }
            public Proveedores()
        {
            InitializeComponent();
            CargarProveedoresPorDefecto();
        }

        private void CargarProveedoresPorDefecto()
        {
            listaProveedores.Add(new Proveedor("Laura Rios", "autocar@empresa1.com", "321654987", "Autocar S.A"));
            listaProveedores.Add(new Proveedor("Javier Torres", "javier@empresa2.com", "987123654", "MotoParts"));
            listaProveedores.Add(new Proveedor("Sofía Ramírez", "sofia@empresa3.com", "456789123", "MotoPower"));
        }

        private void btn_agregarproveedor_Click(object sender, EventArgs e)
        {
            panel_agregarproveedor.Visible = true;
            panel_agregarproveedor.BringToFront();
            int margenInferior = 20;
            int x = (this.Width - panel_agregarproveedor.Width) / 2;
            int y = (this.Height - panel_agregarproveedor.Height) / 2 - margenInferior;
            panel_agregarproveedor.Location = new Point(x, y);
        }

        private void btn_editarproveedor_Click(object sender, EventArgs e)
        {
            panel_editarproveedor.Visible = true;
            panel_editarproveedor.BringToFront();
            int margenInferior = 20;
            int x = (this.Width - panel_editarproveedor.Width) / 2;
            int y = (this.Height - panel_editarproveedor.Height) / 2 - margenInferior;
            panel_editarproveedor.Location = new Point(x, y);
        }

        private void btn_cerraragregar_Click(object sender, EventArgs e)
        {
            panel_agregarproveedor.Visible = false;
            panel_agregarproveedor.SendToBack();
        }

        private void btn_cerrareditar_Click(object sender, EventArgs e)
        {
            panel_editarproveedor.Visible = false;
            panel_editarproveedor.SendToBack();
        }

        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listView_Proveedores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la lista");
                return;
            }

            string empresaSeleccionada = listView_Proveedores.SelectedItems[0].SubItems[0].Text;

            var proveedorAEliminar = listaProveedores.Find(p => p.Empresa == empresaSeleccionada);

            if (proveedorAEliminar != null)
            {
                var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar a la empresa {proveedorAEliminar.Empresa}?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    listaProveedores.Remove(proveedorAEliminar);

                    CargarProveedores();

                    MessageBox.Show("Proveedor eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor");
            }
        }

        private void btn_guardarProveedor_Click(object sender, EventArgs e)
        {
            string empresa = txt_Empresa.Text.Trim();
            string nombreContacto = txt_Nombre.Text.Trim();
            string correo = txt_Correo.Text.Trim();
            string telefono = txt_Telefono.Text.Trim();

            if (string.IsNullOrWhiteSpace(empresa) || string.IsNullOrWhiteSpace(nombreContacto) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaProveedores.Exists(p => p.Empresa == empresa))
            {
                MessageBox.Show("Esa empresa ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoProveedor = new Proveedor(empresa, nombreContacto, correo, telefono);
            listaProveedores.Add(nuevoProveedor);

            MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Empresa.Clear();
            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Telefono.Clear();

            panel_agregarproveedor.Visible = false;
            panel_agregarproveedor.SendToBack();

            CargarProveedores();
        }

        private void CargarProveedores()
        {
            listView_Proveedores.Items.Clear();

            foreach (var proveedor in listaProveedores)
            {
                ListViewItem item = new ListViewItem(proveedor.Empresa);
                item.SubItems.Add(proveedor.NombreContacto);
                item.SubItems.Add(proveedor.Telefono);
                item.SubItems.Add(proveedor.Correo);

                listView_Proveedores.Items.Add(item);
            }
        }

        private void btn_guardareditar_Click(object sender, EventArgs e)
        {
            if (listView_Proveedores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la lista");
                return;
            }

            string nuevaEmpresa = txt_EmpresaE.Text.Trim();
            string nuevoNombre = txt_NombreE.Text.Trim();
            string nuevoCorreo = txt_CorreoE.Text.Trim();
            string nuevoTelefono = txt_TelefonoE.Text.Trim();

            if (string.IsNullOrEmpty(nuevaEmpresa) || string.IsNullOrEmpty(nuevoNombre) ||
                string.IsNullOrEmpty(nuevoCorreo) || string.IsNullOrEmpty(nuevoTelefono))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            string empresaOriginal = listView_Proveedores.SelectedItems[0].SubItems[0].Text;

            Proveedor proveedor = listaProveedores.Find(p => p.Empresa == empresaOriginal);

            if (proveedor != null)
            {
                proveedor.Empresa = nuevaEmpresa;
                proveedor.NombreContacto = nuevoNombre;
                proveedor.Correo = nuevoCorreo;
                proveedor.Telefono = nuevoTelefono;

                CargarProveedores();

                MessageBox.Show("Proveedor editado correctamente");
                panel_editarproveedor.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor");
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

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

        private void guna2PictureBox5_Click_1(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
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

        private void guna2PictureBox7_Click(object sender, EventArgs e)
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

        private void guna2PictureBox8_Click(object sender, EventArgs e)
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

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide(); // Oculta la ventana actual
        }
    }
}
