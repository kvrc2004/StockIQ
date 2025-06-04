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
    public partial class Configuracion : Form
    {
        private Timer timerNotificaciones = new Timer();
        private Random random = new Random();
        private List<string> mensajes = new List<string>
        {
        "📦 Su pedido ya llegó",
        "⚠️ Producto con bajo stock",
        "🛠️ Se ha agregado un nuevo producto",
        "🔄 Inventario actualizado",
        "📊 Consulta tus estadísticas de ventas"
        };

        public Configuracion()
        {
            InitializeComponent();
            TemasApp.AplicarTema(this);
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cierra toda la ventana
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de configuración
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide(); // Oculta la ventana de configuración
        }

        private void ActivarNotificaciones()
        {
            timerNotificaciones.Interval = 8000; // cada 8 segundos
            timerNotificaciones.Tick += (s, e) =>
            {
                int index = random.Next(mensajes.Count);
                string mensaje = mensajes[index];

                NotifyIcon notify = new NotifyIcon
                {
                    Visible = true,
                    Icon = SystemIcons.Information,
                    BalloonTipTitle = "Notificación StockIQ",
                    BalloonTipText = mensaje
                };
                notify.ShowBalloonTip(3000);
            };

            timerNotificaciones.Start();
        }


        private void btn_guardarConfig_Click(object sender, EventArgs e)
        {
            if (cmb_tema.SelectedItem != null)
            {
                TemasApp.TemaActual = cmb_tema.SelectedItem.ToString();
                TemasApp.AplicarTema(this); // Aplicar a Configuración
            }

            if (chk_notificaciones.Checked)
                ActivarNotificaciones();
        }

        private void chk_notificaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_notificaciones.Checked && timerNotificaciones.Enabled)
            {
                timerNotificaciones.Stop();
            }
        }
    }
}
