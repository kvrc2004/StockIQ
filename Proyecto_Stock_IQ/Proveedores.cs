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
        public Proveedores()
        {
            InitializeComponent();
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
    }
}
