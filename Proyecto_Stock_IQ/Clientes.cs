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
            panel_editarcliente.Visible = true;
            panel_editarcliente.BringToFront();
            int margenInferior = 20;
            int x = (this.Width - panel_editarcliente.Width) / 2;
            int y = (this.Height - panel_editarcliente.Height) / 2 -margenInferior;
            panel_editarcliente.Location = new Point(x, y);
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
            if (string.IsNullOrWhiteSpace(gtxt_Nombre.Text) || string.IsNullOrWhiteSpace(gtxt_Correo.Text) ||
                            string.IsNullOrWhiteSpace(gtxt_Telefono.Text) || string.IsNullOrWhiteSpace(gtxt_Direccion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Evita que se agregue un cliente sin datos
            }
            listaClientes.Add(new Cliente(
                gtxt_Nombre.Text,
                gtxt_Correo.Text,
                gtxt_Telefono.Text,
                gtxt_Direccion.Text
            ));
            try
            {
                if (listaClientes.Count != 0)
                {
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        StreamWriter writer = new StreamWriter(Globales.ArchivoClientes, true, Encoding.UTF8); // true para añadir sin sobrescribir, false para sobrescribir el archivo, Encoding para ser especifico con como lo quiere escribir
                        {
                            writer.WriteLine($"{listaClientes[i].Nombre},{listaClientes[i].Correo},{listaClientes[i].Telefono},{listaClientes[i].Direccion}");
                        }
                                                
                        writer.Close();
                    }
                }
                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
