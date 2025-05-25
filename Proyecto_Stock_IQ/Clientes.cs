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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btn_agregarcliente_Click(object sender, EventArgs e)
        {
            panel_agregarcliente.Visible = true;
            panel_agregarcliente.BringToFront();
            int x = (this.Width - panel_agregarcliente.Width) / 2; 
            int y = (this.Height - panel_agregarcliente.Height) / 2; 
            panel_agregarcliente.Location = new Point(x, y);
        }

        private void btn_editarcliente_Click(object sender, EventArgs e)
        {
            panel_editarcliente.Visible = true;
            panel_editarcliente.BringToFront();
            int x = (this.Width - panel_editarcliente.Width) / 2;
            int y = (this.Height - panel_editarcliente.Height) / 2;
            panel_editarcliente.Location = new Point(x, y);
        }
    }
}
