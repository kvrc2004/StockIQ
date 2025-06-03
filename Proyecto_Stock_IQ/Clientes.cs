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
using static Proyecto_Stock_IQ.IniciarSesion;
using static Proyecto_Stock_IQ.Registrar;

namespace Proyecto_Stock_IQ
{
    public partial class Clientes : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        public class Cliente
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }

            public Cliente(string nombre, string correo, string telefono, string direccion)
            {
                Nombre = nombre;
                Correo = correo;
                Telefono = telefono;
                Direccion = direccion;
            }
        }

        public Clientes()
        {
            InitializeComponent();
            CargarClientesPorDefecto();
        }

        private void CargarClientesPorDefecto()
        {
            listaClientes.Add(new Cliente("Ana Gómez", "ana@gmail.com", "123456789", "Calle 1 #23-45"));
            listaClientes.Add(new Cliente("Carlos Ruiz", "carlos@gmail.com", "987654321", "Carrera 7 #56-78"));
            listaClientes.Add(new Cliente("María López", "maria@gmail.com", "555123456", "Avenida 3 #12-34"));
        }

        private void btn_agregarcliente_Click(object sender, EventArgs e)
        {
            panel_agregarcliente.Visible = true;
            panel_agregarcliente.BringToFront();
            int margenInferior = 20;
            int x = (this.Width - panel_agregarcliente.Width) / 2; 
            int y = (this.Height - panel_agregarcliente.Height) / 2 - margenInferior; 
            panel_agregarcliente.Location = new Point(x, y);
        }

        private void btn_editarcliente_Click(object sender, EventArgs e)
        {
            if (listView_Clientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente para editar");
                return;
            }

            string correoSeleccionado = listView_Clientes.SelectedItems[0].SubItems[1].Text;
            Cliente cliente = listaClientes.Find(c => c.Correo == correoSeleccionado);

            if (cliente != null)
            {
                // Pre-cargar datos en campos de edición
                txt_NombreE.Text = cliente.Nombre;
                txt_CorreoE.Text = cliente.Correo;
                txt_TelefonoE.Text = cliente.Telefono;
                txt_FechaE.Text = cliente.Direccion;

                panel_editarcliente.Visible = true;
                panel_editarcliente.BringToFront();
                int margenInferior = 20;
                int x = (this.Width - panel_editarcliente.Width) / 2;
                int y = (this.Height - panel_editarcliente.Height) / 2 - margenInferior;
                panel_editarcliente.Location = new Point(x, y);
            }
            else
            {
                MessageBox.Show("No se encontró el cliente");
            }
        }

        private void btn_cerraragregar_Click(object sender, EventArgs e)
        {
            panel_agregarcliente.Visible = false;
            panel_agregarcliente.SendToBack();
        }

        private void btn_cerrareditar_Click(object sender, EventArgs e)
        {
            panel_editarcliente.Visible = false;
            panel_editarcliente.SendToBack();
        }
        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); 
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana actual
        }

        private void btn_guardarCliente_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txt_Nombre.Text.Trim();
            string nuevoCorreo = txt_Correo.Text.Trim();
            string nuevoTelefono = txt_Telefono.Text.Trim();
            string nuevaDireccion = txt_Direccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoCorreo) ||
                string.IsNullOrWhiteSpace(nuevoTelefono) || string.IsNullOrWhiteSpace(nuevaDireccion))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaClientes.Exists(c => c.Correo == nuevoCorreo))
            {
                MessageBox.Show("Ese correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoCliente = new Cliente(nuevoNombre, nuevoCorreo, nuevoTelefono, nuevaDireccion);
            listaClientes.Add(nuevoCliente);

            MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Telefono.Clear();
            txt_Direccion.Clear();

            panel_agregarcliente.Visible = false;
            panel_agregarcliente.SendToBack();

            CargarClientes();
        }

        private void panel_agregarcliente_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CargarClientes()
        {
            listView_Clientes.Items.Clear();

            foreach (var cliente in listaClientes)
            {
                ListViewItem item = new ListViewItem(cliente.Nombre);
                item.SubItems.Add(cliente.Correo);
                item.SubItems.Add(cliente.Telefono);
                item.SubItems.Add(cliente.Direccion);

                listView_Clientes.Items.Add(item);
            }
        }

        private void panel_editarcliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardareditar_Click(object sender, EventArgs e)
        {
            if (listView_Clientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente de la lista");
                return;
            }

            string nuevoNombre = txt_NombreE.Text.Trim();
            string nuevoCorreo = txt_CorreoE.Text.Trim();
            string nuevoTelefono = txt_TelefonoE.Text.Trim();
            string nuevaDireccion = txt_FechaE.Text.Trim();

            if (string.IsNullOrEmpty(nuevoNombre) || string.IsNullOrEmpty(nuevoCorreo) ||
                string.IsNullOrEmpty(nuevoTelefono) || string.IsNullOrEmpty(nuevaDireccion))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            string correoOriginal = listView_Clientes.SelectedItems[0].SubItems[1].Text;

            Cliente cliente = listaClientes.Find(c => c.Correo == correoOriginal);

            if (cliente != null)
            {
                cliente.Nombre = nuevoNombre;
                cliente.Correo = nuevoCorreo;
                cliente.Telefono = nuevoTelefono;
                cliente.Direccion = nuevaDireccion;

                CargarClientes();

                MessageBox.Show("Cliente editado correctamente");
                panel_editarcliente.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el cliente");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listView_Clientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente de la lista");
                return;
            }

            string correoSeleccionado = listView_Clientes.SelectedItems[0].SubItems[1].Text;

            var clienteAEliminar = listaClientes.Find(c => c.Correo == correoSeleccionado);

            if (clienteAEliminar != null)
            {
                var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar al cliente {clienteAEliminar.Nombre}?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    listaClientes.Remove(clienteAEliminar);

                    CargarClientes();

                    MessageBox.Show("Cliente eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el cliente");
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}


